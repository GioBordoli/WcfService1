using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCtoF_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
                if (int.TryParse(txtCelsius.Text, out int celsius))
                {
                    try
                    {
                        int fahrenheit = client.c2f(celsius);
                        lblFahrenheit.Text = $"Result: {fahrenheit} °F";
                    }
                    catch (Exception ex)
                    {
                        lblFahrenheit.Text = $"Error: {ex.Message}";
                    }
                }
                else
                {
                    lblFahrenheit.Text = "Invalid input. Please enter an integer.";
                }
            }
        }

        protected void btnFtoC_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
                if (int.TryParse(txtFahrenheit.Text, out int fahrenheit))
                {
                    try
                    {
                        int celsius = client.f2c(fahrenheit);
                        lblCelsius.Text = $"Result: {celsius} °C";
                    }
                    catch (Exception ex)
                    {
                        lblCelsius.Text = $"Error: {ex.Message}";
                    }
                }
                else
                {
                    lblCelsius.Text = "Invalid input. Please enter an integer.";
                }
            }
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
                string input = txtNumbers.Text;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    try
                    {
                        string sorted = client.sort(input);
                        lblSortedNumbers.Text = $"Sorted: {sorted}";
                    }
                    catch (Exception ex)
                    {
                        lblSortedNumbers.Text = $"Error: {ex.Message}";
                    }
                }
                else
                {
                    lblSortedNumbers.Text = "Please enter a comma-separated list of numbers.";
                }
            }
        }
    }
}
