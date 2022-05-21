namespace WFAMuzikCalma
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
            this.btnSasir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSasir
            // 
            this.btnSasir.Location = new System.Drawing.Point(50, 13);
            this.btnSasir.Name = "btnSasir";
            this.btnSasir.Size = new System.Drawing.Size(75, 35);
            this.btnSasir.TabIndex = 0;
            this.btnSasir.Text = "ŞAŞIR";
            this.btnSasir.UseVisualStyleBackColor = true;
            this.btnSasir.Click += new System.EventHandler(this.btnSasir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 60);
            this.Controls.Add(this.btnSasir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSasir;
    }
}

