using System;
using System.Windows.Forms;

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
            // Set a default URL and navigate immediately
            txtUrl.Text = "https://www.google.com";
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                // Ensure the string starts with 'http' for valid navigation
                if (!txtUrl.Text.StartsWith("http"))
                {
                    txtUrl.Text = "https://" + txtUrl.Text;
                }
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Update the address bar to reflect current page
            txtUrl.Text = webBrowser1.Url.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event is fired whenever txtUrl.Text changes
            // Add logic here if needed, or leave it empty
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            // Let user press Enter in the textbox to navigate
            if (e.KeyCode == Keys.Enter)
            {
                go_btn.PerformClick();
            }
        }
    }
}
