using System;
using System.Windows.Forms;

using WindowsFormsApp1.EncryptionServiceRef;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // --------------------------------
            // 1) Browser default setup
            // --------------------------------
            txtUrl.Text = "https://www.google.com";
            webBrowser1.Navigate(txtUrl.Text);

            // --------------------------------
            // 2) Calculator Setup
            // --------------------------------
            comboBox1.Items.AddRange(new string[] { "+", "-", "*", "/" });
            comboBox1.SelectedIndex = 0; // Default operation

            // --------------------------------
            // 3) Encryption/Decryption Buttons
            // --------------------------------
            encryptBtn.Text = "Encrypt";
            decryptBtn.Text = "Decrypt";
        }

        // ─────────────────────────────────────────────
        // BROWSER CODE
        // ─────────────────────────────────────────────
        private void go_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                if (!txtUrl.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    txtUrl.Text = "https://" + txtUrl.Text;
                }
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = webBrowser1.Url.ToString();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                go_btn.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // ─────────────────────────────────────────────
        // CALCULATOR CODE
        // ─────────────────────────────────────────────
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double val1 = double.Parse(num1.Text);
                double val2 = double.Parse(num2.Text);
                string op = comboBox1.SelectedItem.ToString();
                double calcResult = 0;

                switch (op)
                {
                    case "+":
                        calcResult = val1 + val2;
                        break;
                    case "-":
                        calcResult = val1 - val2;
                        break;
                    case "*":
                        calcResult = val1 * val2;
                        break;
                    case "/":
                        if (val2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        calcResult = val1 / val2;
                        break;
                }

                result.Text = calcResult.ToString();
            }
            catch (Exception ex)
            {
                result.Text = "Error!";
                Console.WriteLine(ex.Message);
            }
        }

        private void num1_TextChanged(object sender, EventArgs e) { }
        private void num2_TextChanged(object sender, EventArgs e) { }
        private void result_Click(object sender, EventArgs e) { }

        // ─────────────────────────────────────────────
        // ENCRYPT / DECRYPT CODE
        // ─────────────────────────────────────────────
        private void encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                using (ServiceClient client = new ServiceClient())
                {
                    string plainText = encryptTxtBox.Text.Trim();
                    string encryptedValue = client.Encrypt(plainText);
                    encryptionResult.Text = encryptedValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption error: " + ex.Message);
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                using (ServiceClient client = new ServiceClient())
                {
                    // Decrypt from what the user typed in decryptTxtBox
                    string encryptedText = decryptTxtBox.Text.Trim();
                    string decryptedValue = client.Decrypt(encryptedText);
                    decryptionResult.Text = decryptedValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error: " + ex.Message);
            }
        }

        // Unused but wired-up event handlers:
        private void cryptoResult_Click(object sender, EventArgs e) { }
        private void stringBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void decryptTxtBox_TextChanged(object sender, EventArgs e) { }
    }
}
