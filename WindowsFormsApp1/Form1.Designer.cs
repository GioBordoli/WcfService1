namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.go_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.num1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.equealSign = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.encryptTxtBox = new System.Windows.Forms.TextBox();
            this.encryptionResult = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.decryptTxtBox = new System.Windows.Forms.TextBox();
            this.decryptionResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
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
            this.webBrowser1.Size = new System.Drawing.Size(626, 338);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(71, 430);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 6;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(304, 430);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 9;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // equealSign
            // 
            this.equealSign.AutoSize = true;
            this.equealSign.Location = new System.Drawing.Point(410, 433);
            this.equealSign.Name = "equealSign";
            this.equealSign.Size = new System.Drawing.Size(13, 13);
            this.equealSign.TabIndex = 10;
            this.equealSign.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(451, 433);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 11;
            this.result.Text = "result";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // encryptTxtBox
            // 
            this.encryptTxtBox.Location = new System.Drawing.Point(71, 480);
            this.encryptTxtBox.Name = "encryptTxtBox";
            this.encryptTxtBox.Size = new System.Drawing.Size(100, 20);
            this.encryptTxtBox.TabIndex = 12;
            this.encryptTxtBox.Text = "textToEncrypt";
            this.encryptTxtBox.TextChanged += new System.EventHandler(this.stringBox_TextChanged);
            // 
            // encryptionResult
            // 
            this.encryptionResult.AutoSize = true;
            this.encryptionResult.Location = new System.Drawing.Point(301, 483);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(86, 13);
            this.encryptionResult.TabIndex = 15;
            this.encryptionResult.Text = "encryptionResult";
            this.encryptionResult.Click += new System.EventHandler(this.cryptoResult_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(198, 478);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 16;
            this.encryptBtn.Text = "encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(198, 517);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 17;
            this.decryptBtn.Text = "decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // decryptTxtBox
            // 
            this.decryptTxtBox.Location = new System.Drawing.Point(71, 520);
            this.decryptTxtBox.Name = "decryptTxtBox";
            this.decryptTxtBox.Size = new System.Drawing.Size(100, 20);
            this.decryptTxtBox.TabIndex = 18;
            this.decryptTxtBox.Text = "textToDecrypt";
            this.decryptTxtBox.TextChanged += new System.EventHandler(this.decryptTxtBox_TextChanged);
            // 
            // decryptionResult
            // 
            this.decryptionResult.AutoSize = true;
            this.decryptionResult.Location = new System.Drawing.Point(301, 527);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.Size = new System.Drawing.Size(86, 13);
            this.decryptionResult.TabIndex = 19;
            this.decryptionResult.Text = "decryptionResult";
            this.decryptionResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.decryptionResult);
            this.Controls.Add(this.decryptTxtBox);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.encryptionResult);
            this.Controls.Add(this.encryptTxtBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equealSign);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label equealSign;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox encryptTxtBox;
        private System.Windows.Forms.Label encryptionResult;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox decryptTxtBox;
        private System.Windows.Forms.Label decryptionResult;
    }
}
