using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geocoding
{
    public partial class FormGeocoding : Form
    {
        public FormGeocoding()
        {
            InitializeComponent();
            panelSearch.Top = 90;
            panelFetch.Top = 90;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFetch.Visible = false;
            panelSearch.Visible = true;
            richTextBoxLocation.Clear();
        }

        private void fetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            panelFetch.Visible = true;
            richTextBoxLocation.Clear();
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            timerLed.Enabled = true;
            labelLed.Visible = true;

            richTextBoxLocation.Clear();
            this.Refresh();

            var client = new RestClient(textBoxUrl.Text);
            var request = new RestRequest("v1/search.php", Method.GET);

            request.AddParameter("key", ApiConfig.Key);
            request.AddParameter("q", textBoxQuery.Text);
            request.AddParameter("addressdetails", 1);
            request.AddParameter("namedetails", 4);
            request.AddParameter("extratags", 1);
            request.AddParameter("polygon", 1);
            request.AddParameter("format", textBoxSearchFormat.Text);

            // additional parameters are:
            // limit 1 - n

            //var content = await SearchLocationAsync();
            var response = await client.ExecuteTaskAsync<string>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = JsonConvert.DeserializeObject<List<Geocoding.Location>>(response.Content);

                // out location
                richTextBoxLocation.Font = new Font("Calibri", 10, FontStyle.Regular);
                richTextBoxLocation.AppendText($"{content[0]}\n");
                richTextBoxLocation.AppendText($"PolygonPoints:\n");
                foreach (var item in content[0].PolygonPoints)
                    richTextBoxLocation.AppendText($"lon={item[0]} : lat={item[1]}\n");

                // out formated json
                var jsonData = response.Content;
                var jsonFormated = FormatJson(jsonData);

                richTextBoxJson.Text = jsonFormated;
                richTextBoxJson.Refresh();
            }

            labelLed.Visible = false;
            timerLed.Enabled = false;
        }

        private async void buttonFetch_Click(object sender, EventArgs e)
        {
            timerLed.Enabled = true;
            labelLed.Visible = true;

            richTextBoxLocation.Clear();
            this.Refresh();

            var client = new RestClient(this.textBoxUrl.Text);
            var request = new RestRequest($"v1/reverse.php?key={ApiConfig.Key}&" +
                $"lon={textBoxLng.Text}&" +
                $"lat={textBoxLat.Text}&" +
                $"format={textBoxFormat.Text}&" +
                $"zoom={textBoxZoom.Text}", Method.GET);

            var response = await client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
            {
                var jsonData = response.Content;
                var content = JsonConvert.DeserializeObject<Geocoding.Location>(response.Content);

                // out location
                richTextBoxLocation.Font = new Font("Calibri", 10, FontStyle.Regular);

                var s = $"place_id : {content.Place_Id}\n" +
                    $"licence : {content.Licence}\n" +
                    $"lat : {content.Lat}\n" +
                    $"lon : {content.Lon}\n" +
                    $"display_name : {content.Display_Name}\n" +
                    $"address:\n";

                foreach (var item in content.Address)
                    s += $"\t{item.Key} : {item.Value}\n";

                s += $"boundingbox:\n";
                foreach (var item in content.Boundingbox)
                    s += $"\t{item}\n";

                richTextBoxLocation.Text = s;

                // out formatet json
                var jsonFormated = FormatJson(jsonData);

                richTextBoxJson.Text = jsonFormated;
                richTextBoxJson.Refresh();
            }

            labelLed.Visible = false;
            timerLed.Enabled = false;
        }

        private static string FormatJson(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        public async Task<string> SearchLocationAsync()
        {
            var client = new RestClient(textBoxUrl.Text);
            var request = new RestRequest("v1/search.php", Method.GET);

            request.AddParameter("key", ApiConfig.Key);
            request.AddParameter("q", textBoxQuery.Text);
            request.AddParameter("addressdetails", 1);
            request.AddParameter("namedetails", 4);
            request.AddParameter("extratags", 1);
            request.AddParameter("polygon", 1);
            request.AddParameter("format", textBoxSearchFormat.Text);

            // additional parameters are:
            // limit 1 - n

            var response = await client.ExecuteTaskAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                return String.Empty;
            }

        }

        private void timerLed_Tick(object sender, EventArgs e)
        {
            labelLed.Visible = !labelLed.Visible;
        }

        private void FormGeocoding_Click(object sender, EventArgs e)
        {
            timerLed.Enabled = true;
            labelLed.Visible = true;
        }
    }
}
