namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
<<<<<<< Updated upstream
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(233, 47);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(300, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(71, 44);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.Location = new System.Drawing.Point(152, 44);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(75, 23);
            this.forward_btn.TabIndex = 2;
            this.forward_btn.Text = "Forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(539, 47);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(75, 23);
            this.go_btn.TabIndex = 3;
            this.go_btn.Text = "Go!";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(620, 47);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(69, 73);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(626, 292);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.txtUrl);
>>>>>>> Stashed changes
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

