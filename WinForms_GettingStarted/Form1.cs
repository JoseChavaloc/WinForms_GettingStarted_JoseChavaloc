using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_GettingStarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
        }
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;

            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }
        private void NavegarDesdeTextBox()
        {
            string url = ObtenerURLValida(addressBar.Text);
            webView.Source = new Uri(url);
            addressBar.Text = url;
        }
        private string ObtenerURLValida(string entrada)
        {
            entrada = entrada.Trim();

            if (!entrada.Contains("."))
            {
                return "https://www.google.com/search?q=" + Uri.EscapeDataString(entrada);
            }

            if (!entrada.StartsWith("https://", StringComparison.OrdinalIgnoreCase) &&
                !entrada.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {
                entrada = "https://" + entrada;
            }

            return entrada;
        }
    }
}
