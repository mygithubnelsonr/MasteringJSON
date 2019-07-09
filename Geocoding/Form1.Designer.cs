namespace Geocoding
{
    partial class FormGeocoding
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
            this.components = new System.ComponentModel.Container();
            this.richTextBoxLocation = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxFetchKey = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLng = new System.Windows.Forms.TextBox();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFetch = new System.Windows.Forms.Panel();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearchFormat = new System.Windows.Forms.TextBox();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearchKey = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxJson = new System.Windows.Forms.RichTextBox();
            this.labelLed = new System.Windows.Forms.Label();
            this.timerLed = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelFetch.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLocation
            // 
            this.richTextBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLocation.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxLocation.Name = "richTextBoxLocation";
            this.richTextBoxLocation.Size = new System.Drawing.Size(561, 341);
            this.richTextBoxLocation.TabIndex = 1;
            this.richTextBoxLocation.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.fetchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // fetchToolStripMenuItem
            // 
            this.fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            this.fetchToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fetchToolStripMenuItem.Text = "Fetch";
            this.fetchToolStripMenuItem.Click += new System.EventHandler(this.fetchToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LocationIQ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Latitude:";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxUrl.Location = new System.Drawing.Point(81, 31);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(242, 20);
            this.textBoxUrl.TabIndex = 7;
            this.textBoxUrl.Text = "https://eu1.locationiq.com";
            // 
            // textBoxFetchKey
            // 
            this.textBoxFetchKey.Location = new System.Drawing.Point(76, 0);
            this.textBoxFetchKey.Name = "textBoxFetchKey";
            this.textBoxFetchKey.PasswordChar = '*';
            this.textBoxFetchKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxFetchKey.TabIndex = 8;
            this.textBoxFetchKey.Text = "7cdb359e3895ca";
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(76, 34);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(100, 20);
            this.textBoxLat.TabIndex = 9;
            this.textBoxLat.Text = "48.3098394";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Longitude:";
            // 
            // textBoxLng
            // 
            this.textBoxLng.Location = new System.Drawing.Point(76, 67);
            this.textBoxLng.Name = "textBoxLng";
            this.textBoxLng.Size = new System.Drawing.Size(100, 20);
            this.textBoxLng.TabIndex = 11;
            this.textBoxLng.Text = "11.5715474";
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.Location = new System.Drawing.Point(76, 101);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.Size = new System.Drawing.Size(100, 20);
            this.textBoxZoom.TabIndex = 13;
            this.textBoxZoom.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zoom:";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(76, 134);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(100, 20);
            this.textBoxFormat.TabIndex = 15;
            this.textBoxFormat.Text = "json";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Format:";
            // 
            // panelFetch
            // 
            this.panelFetch.Controls.Add(this.buttonFetch);
            this.panelFetch.Controls.Add(this.label4);
            this.panelFetch.Controls.Add(this.textBoxFormat);
            this.panelFetch.Controls.Add(this.label3);
            this.panelFetch.Controls.Add(this.label7);
            this.panelFetch.Controls.Add(this.textBoxFetchKey);
            this.panelFetch.Controls.Add(this.textBoxZoom);
            this.panelFetch.Controls.Add(this.textBoxLat);
            this.panelFetch.Controls.Add(this.label6);
            this.panelFetch.Controls.Add(this.label5);
            this.panelFetch.Controls.Add(this.textBoxLng);
            this.panelFetch.Location = new System.Drawing.Point(12, 233);
            this.panelFetch.Name = "panelFetch";
            this.panelFetch.Size = new System.Drawing.Size(190, 200);
            this.panelFetch.TabIndex = 16;
            this.panelFetch.Visible = false;
            // 
            // buttonFetch
            // 
            this.buttonFetch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFetch.Location = new System.Drawing.Point(0, 177);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(190, 23);
            this.buttonFetch.TabIndex = 16;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label10);
            this.panelSearch.Controls.Add(this.label9);
            this.panelSearch.Controls.Add(this.textBoxSearchFormat);
            this.panelSearch.Controls.Add(this.textBoxQuery);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.label8);
            this.panelSearch.Controls.Add(this.textBoxSearchKey);
            this.panelSearch.Location = new System.Drawing.Point(12, 90);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(190, 137);
            this.panelSearch.TabIndex = 17;
            this.panelSearch.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Format:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Query:";
            // 
            // textBoxSearchFormat
            // 
            this.textBoxSearchFormat.Location = new System.Drawing.Point(76, 70);
            this.textBoxSearchFormat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.textBoxSearchFormat.Name = "textBoxSearchFormat";
            this.textBoxSearchFormat.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchFormat.TabIndex = 13;
            this.textBoxSearchFormat.Text = "json";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(76, 35);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuery.TabIndex = 13;
            this.textBoxQuery.Text = "Landshut";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSearch.Location = new System.Drawing.Point(0, 114);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(190, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Key:";
            // 
            // textBoxSearchKey
            // 
            this.textBoxSearchKey.Location = new System.Drawing.Point(76, 0);
            this.textBoxSearchKey.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.textBoxSearchKey.Name = "textBoxSearchKey";
            this.textBoxSearchKey.PasswordChar = '*';
            this.textBoxSearchKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchKey.TabIndex = 10;
            this.textBoxSearchKey.Text = "7cdb359e3895ca";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(222, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 373);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxLocation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Location.ToString";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxJson);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formated JSON";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxJson
            // 
            this.richTextBoxJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxJson.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxJson.Name = "richTextBoxJson";
            this.richTextBoxJson.Size = new System.Drawing.Size(561, 341);
            this.richTextBoxJson.TabIndex = 0;
            this.richTextBoxJson.Text = "";
            // 
            // labelLed
            // 
            this.labelLed.AutoSize = true;
            this.labelLed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed.ForeColor = System.Drawing.Color.Red;
            this.labelLed.Location = new System.Drawing.Point(358, 38);
            this.labelLed.Name = "labelLed";
            this.labelLed.Size = new System.Drawing.Size(119, 13);
            this.labelLed.TabIndex = 19;
            this.labelLed.Text = "  waiting for data ...";
            this.labelLed.Visible = false;
            // 
            // timerLed
            // 
            this.timerLed.Interval = 500;
            this.timerLed.Tick += new System.EventHandler(this.timerLed_Tick);
            // 
            // FormGeocoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 469);
            this.Controls.Add(this.labelLed);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelFetch);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGeocoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geocoding";
            this.Click += new System.EventHandler(this.FormGeocoding_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFetch.ResumeLayout(false);
            this.panelFetch.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxFetchKey;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLng;
        private System.Windows.Forms.TextBox textBoxZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Panel panelFetch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearchKey;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearchFormat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxJson;
        private System.Windows.Forms.Label labelLed;
        private System.Windows.Forms.Timer timerLed;
    }
}

