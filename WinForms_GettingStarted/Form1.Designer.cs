namespace WinForms_GettingStarted
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 60);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1081, 472);
            this.webView.Source = new System.Uri("https://www.microsoft.com/", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(208, 14);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(586, 20);
            this.addressBar.TabIndex = 1;
            this.addressBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(815, 11);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Ir";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 527);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button goButton;
    }
}

