namespace MySQLDataBaseInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandButton = new System.Windows.Forms.Button();
            this.result_richText = new System.Windows.Forms.RichTextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panelTableData = new System.Windows.Forms.Panel();
            this.labelTableName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonGraphSave = new System.Windows.Forms.Button();
            this.panelTableData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.commandTextBox.Location = new System.Drawing.Point(13, 45);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(611, 26);
            this.commandTextBox.TabIndex = 0;
            // 
            // commandButton
            // 
            this.commandButton.Font = new System.Drawing.Font("Camp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandButton.Location = new System.Drawing.Point(633, 45);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(75, 26);
            this.commandButton.TabIndex = 1;
            this.commandButton.Text = "SEND";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // result_richText
            // 
            this.result_richText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_richText.BackColor = System.Drawing.Color.Gray;
            this.result_richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_richText.DetectUrls = false;
            this.result_richText.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_richText.ForeColor = System.Drawing.Color.White;
            this.result_richText.Location = new System.Drawing.Point(12, 77);
            this.result_richText.Name = "result_richText";
            this.result_richText.ReadOnly = true;
            this.result_richText.Size = new System.Drawing.Size(612, 155);
            this.result_richText.TabIndex = 2;
            this.result_richText.Text = "";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.userIdTextBox.Location = new System.Drawing.Point(12, 10);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.userIdTextBox.TabIndex = 3;
            this.userIdTextBox.Text = "User Id";
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userIdTextBox.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Camp", 12F);
            this.connectButton.Location = new System.Drawing.Point(633, 10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 26);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(218, 10);
            this.passwordTextBox.MaxLength = 35;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 26);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // panelTableData
            // 
            this.panelTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTableData.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTableData.Controls.Add(this.labelTableName);
            this.panelTableData.Controls.Add(this.dataGridView1);
            this.panelTableData.Controls.Add(this.labelDatabaseName);
            this.panelTableData.Location = new System.Drawing.Point(12, 238);
            this.panelTableData.Name = "panelTableData";
            this.panelTableData.Size = new System.Drawing.Size(612, 258);
            this.panelTableData.TabIndex = 7;
            // 
            // labelTableName
            // 
            this.labelTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTableName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTableName.Location = new System.Drawing.Point(351, 39);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(0, 18);
            this.labelTableName.TabIndex = 2;
            this.labelTableName.Text = "Table Name : NULL";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 195);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDatabaseName.Location = new System.Drawing.Point(330, 12);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(0, 18);
            this.labelDatabaseName.TabIndex = 0;
            this.labelDatabaseName.Text = "Data Base Name : NULL";
            this.labelDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDatabase.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.textBoxDatabase.Location = new System.Drawing.Point(424, 10);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(200, 26);
            this.textBoxDatabase.TabIndex = 8;
            this.textBoxDatabase.Text = "Database";
            this.textBoxDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDatabase.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(633, 77);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "value";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(382, 342);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Title Test";
            this.chart.Titles.Add(title1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Font = new System.Drawing.Font("Camp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(633, 425);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(382, 26);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "LOAD";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonGraphSave
            // 
            this.buttonGraphSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGraphSave.Font = new System.Drawing.Font("Camp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraphSave.Location = new System.Drawing.Point(633, 457);
            this.buttonGraphSave.Name = "buttonGraphSave";
            this.buttonGraphSave.Size = new System.Drawing.Size(382, 26);
            this.buttonGraphSave.TabIndex = 11;
            this.buttonGraphSave.Text = "SAVE";
            this.buttonGraphSave.UseVisualStyleBackColor = true;
            this.buttonGraphSave.Click += new System.EventHandler(this.buttonGraphSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1027, 498);
            this.Controls.Add(this.buttonGraphSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.panelTableData);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.result_richText);
            this.Controls.Add(this.commandButton);
            this.Controls.Add(this.commandTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MySQL Database Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelTableData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.RichTextBox result_richText;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panelTableData;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonGraphSave;
    }
}

