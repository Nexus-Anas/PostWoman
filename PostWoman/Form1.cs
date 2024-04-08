using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostWoman
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e) => HttpSelector.SelectedIndex = 0;




        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;




        private async void BtnRun_Click(object sender, EventArgs e)
        {
            string apiUrl = TxtUrl.Text.Trim();
            string httpMethod = HttpSelector.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(apiUrl) || string.IsNullOrEmpty(httpMethod))
            {
                MessageBox.Show("Please enter API URL and select HTTP method.");
                return;
            }

            try
            {
                HttpResponseMessage response = null;

                switch (httpMethod.ToUpper())
                {
                    case "GET":
                        response = await httpClient.GetAsync(apiUrl);
                        break;
                    case "POST":
                        string requestBody = TxtRequestBody.Text.Trim();
                        var postContent = new StringContent(requestBody, Encoding.UTF8, "application/json");
                        response = await httpClient.PostAsync(apiUrl, postContent);
                        break;
                    case "PUT":
                        string putBody = TxtRequestBody.Text.Trim();
                        var putContent = new StringContent(putBody, Encoding.UTF8, "application/json");
                        response = await httpClient.PutAsync(apiUrl, putContent);
                        break;
                    case "PATCH":
                        string patchBody = TxtRequestBody.Text.Trim();
                        var patchRequest = new HttpRequestMessage(new HttpMethod("PATCH"), apiUrl)
                        {
                            Content = new StringContent(patchBody, Encoding.UTF8, "application/json")
                        };
                        response = await httpClient.SendAsync(patchRequest);
                        break;
                    case "DELETE":
                        response = await httpClient.DeleteAsync(apiUrl);
                        break;
                }

                if (response != null)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var parseJson = JToken.Parse(responseBody);
                    TxtOutput.Text = parseJson.ToString(Formatting.Indented);
                    LblStatusCode.Text = $"{(int)response.StatusCode} {response.StatusCode}";
                    SetStatusLabelColor(response.StatusCode);
                    TxtError.Text = ""; // Clear any previous error message
                }
                else
                {
                    MessageBox.Show("Failed to get response from the server.");
                }
            }
            catch (Exception ex)
            {
                LblStatusCode.Text = "";
                TxtError.Text = ex.Message;
                LblStatusCode.ForeColor = Color.Crimson;
            }
        }




        private void SetStatusLabelColor(System.Net.HttpStatusCode statusCode)
        {
            switch (statusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    LblStatusCode.ForeColor = Color.MediumSpringGreen;
                    break;
                case System.Net.HttpStatusCode.InternalServerError:
                    LblStatusCode.ForeColor = Color.Crimson;
                    break;
                case System.Net.HttpStatusCode.Created:
                    LblStatusCode.ForeColor = Color.DodgerBlue;
                    break;
                case System.Net.HttpStatusCode.BadRequest:
                    LblStatusCode.ForeColor = Color.Crimson;
                    break;
                case System.Net.HttpStatusCode.Unauthorized:
                    LblStatusCode.ForeColor = Color.DarkOrange;
                    break;
                default:
                    LblStatusCode.ForeColor = Color.White;
                    break;
            }
        }
    }
}