using System;
using System.Windows.Forms;
using WindowsFormApp3.EncryptionService; // Ensure this matches the namespace from Service Reference

namespace WindowsFormApp3
{
    public partial class Form1 : Form
    {
        // Initialize service client
        EncryptionWcfClient encryptionClient = new EncryptionWcfClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            PerformEncryption();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            PerformDecryption();
        }

        private void PerformEncryption()
        {
            try
            {
                string inputText = txtInput.Text;
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Please enter text to encrypt.");
                    return;
                }

                string encryptedText = encryptionClient.Encrypt(inputText);
                lblResult.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during encryption: " + ex.Message);
            }
        }

        private void PerformDecryption()
        {
            try
            {
                string inputText = txtInput.Text;
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Please enter text to decrypt.");
                    return;
                }

                string decryptedText = encryptionClient.Decrypt(inputText);
                lblResult.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during decryption: " + ex.Message);
            }
        }
    }
}

