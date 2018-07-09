namespace USB_Sniffer_Opener
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(12, 17);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(181, 23);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKapa
            // 
            this.btnKapa.Location = new System.Drawing.Point(199, 19);
            this.btnKapa.Name = "btnKapa";
            this.btnKapa.Size = new System.Drawing.Size(181, 23);
            this.btnKapa.TabIndex = 0;
            this.btnKapa.Text = "Kapat";
            this.btnKapa.UseVisualStyleBackColor = true;
            this.btnKapa.Click += new System.EventHandler(this.btnKapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 54);
            this.Controls.Add(this.btnKapa);
            this.Controls.Add(this.btnAc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Sniffer Opener";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKapa;
    }
}

