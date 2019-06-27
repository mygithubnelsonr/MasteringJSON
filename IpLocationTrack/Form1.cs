using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace IpLocationTrack
{
    public partial class FormIpLocationTrack : Form
    {
        int splitterDistance = 265;
        int lvColumn1 = 122;
        int lvColumn2 = 222;

        public FormIpLocationTrack()
        {
            InitializeComponent();
        }

        private void FormIpLocationTrack_Resize(object sender, EventArgs e)
        {
            Debug.Print($"Formwidht={this.Width}, Formheight={this.Height}");
            splitContainer1.SplitterDistance = splitterDistance;
            listViewIPLocation.Columns[0].Width = lvColumn1;
            listViewIPLocation.Columns[1].Width = lvColumn2;
        }

        private void FormIpLocationTrack_Load(object sender, EventArgs e)
        {
            this.Width = 686;
            splitContainer1.SplitterDistance = splitterDistance;
            listViewIPLocation.Columns[0].Width = lvColumn1;
            listViewIPLocation.Columns[1].Width = lvColumn2;
        }

        private void buttonLoadIpLocation_Click(object sender, EventArgs e)
        {
            string url = "";

            richTextBox1.Clear();
            listViewIPLocation.Items.Clear();
            this.Refresh();


            if (String.IsNullOrEmpty(textBoxIP.Text))
                url = "https://ipapi.co/json";
            else
                url = $"https://ipapi.co/{textBoxIP.Text}/json";

            var client = new RestClient(url);
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);
            bool success = response.IsSuccessful;
            Debug.Print($"response execute success={success}");

            var jsonData = response.Content;
            response = null;

            var dictionary = JsonConvert.DeserializeObject<IDictionary<string, string>>(jsonData);

            foreach (string key in dictionary.Keys)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = key;
                listViewItem.SubItems.Add(dictionary[key]);
                listViewIPLocation.Items.Add(listViewItem);
            }

            richTextBox1.Text = jsonData;

            //this.Refresh();
            richTextBox1.Refresh();
            listViewIPLocation.Refresh();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Debug.Print($"SplitterDistance={splitContainer1.SplitterDistance}");
        }

        private void listViewIPLocation_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            Debug.Print($"Column1={listViewIPLocation.Columns[0].Width},Column2={listViewIPLocation.Columns[1].Width}");
        }


    }
}
