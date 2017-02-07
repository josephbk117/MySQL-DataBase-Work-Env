namespace MySQLDataBaseInterface
{
    partial class GraphViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxGraphView = new System.Windows.Forms.ComboBox();
            this.buttonGraphSave = new System.Windows.Forms.Button();
            this.comboBoxXaxis = new System.Windows.Forms.ComboBox();
            this.comboBoxYaxis = new System.Windows.Forms.ComboBox();
            this.labelXvalue = new System.Windows.Forms.Label();
            this.labelYAxisValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(13, 39);
            this.chart.Name = "chart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "value1";
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(783, 332);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // comboBoxGraphView
            // 
            this.comboBoxGraphView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGraphView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGraphView.FormattingEnabled = true;
            this.comboBoxGraphView.Items.AddRange(new object[] {
            "Bar Graph",
            "Pie Chart",
            "Line Graph"});
            this.comboBoxGraphView.Location = new System.Drawing.Point(533, 12);
            this.comboBoxGraphView.Name = "comboBoxGraphView";
            this.comboBoxGraphView.Size = new System.Drawing.Size(263, 21);
            this.comboBoxGraphView.TabIndex = 1;
            this.comboBoxGraphView.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraphView_SelectedIndexChanged);
            // 
            // buttonGraphSave
            // 
            this.buttonGraphSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGraphSave.Location = new System.Drawing.Point(699, 373);
            this.buttonGraphSave.Name = "buttonGraphSave";
            this.buttonGraphSave.Size = new System.Drawing.Size(97, 26);
            this.buttonGraphSave.TabIndex = 2;
            this.buttonGraphSave.Text = "SAVE";
            this.buttonGraphSave.UseVisualStyleBackColor = true;
            this.buttonGraphSave.Click += new System.EventHandler(this.buttonGraphSave_Click);
            // 
            // comboBoxXaxis
            // 
            this.comboBoxXaxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxXaxis.FormattingEnabled = true;
            this.comboBoxXaxis.Location = new System.Drawing.Point(109, 377);
            this.comboBoxXaxis.Name = "comboBoxXaxis";
            this.comboBoxXaxis.Size = new System.Drawing.Size(151, 21);
            this.comboBoxXaxis.TabIndex = 3;
            this.comboBoxXaxis.SelectedIndexChanged += new System.EventHandler(this.comboBoxXaxis_SelectedIndexChanged);
            // 
            // comboBoxYaxis
            // 
            this.comboBoxYaxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxYaxis.FormattingEnabled = true;
            this.comboBoxYaxis.Location = new System.Drawing.Point(364, 377);
            this.comboBoxYaxis.Name = "comboBoxYaxis";
            this.comboBoxYaxis.Size = new System.Drawing.Size(151, 21);
            this.comboBoxYaxis.TabIndex = 4;
            this.comboBoxYaxis.SelectedIndexChanged += new System.EventHandler(this.comboBoxXaxis_SelectedIndexChanged);
            // 
            // labelXvalue
            // 
            this.labelXvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelXvalue.AutoSize = true;
            this.labelXvalue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelXvalue.Location = new System.Drawing.Point(58, 380);
            this.labelXvalue.Name = "labelXvalue";
            this.labelXvalue.Size = new System.Drawing.Size(45, 13);
            this.labelXvalue.TabIndex = 5;
            this.labelXvalue.Text = "X Axis : ";
            // 
            // labelYAxisValue
            // 
            this.labelYAxisValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelYAxisValue.AutoSize = true;
            this.labelYAxisValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelYAxisValue.Location = new System.Drawing.Point(313, 380);
            this.labelYAxisValue.Name = "labelYAxisValue";
            this.labelYAxisValue.Size = new System.Drawing.Size(45, 13);
            this.labelYAxisValue.TabIndex = 6;
            this.labelYAxisValue.Text = "Y Axis : ";
            // 
            // GraphViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(808, 406);
            this.Controls.Add(this.labelYAxisValue);
            this.Controls.Add(this.labelXvalue);
            this.Controls.Add(this.comboBoxYaxis);
            this.Controls.Add(this.comboBoxXaxis);
            this.Controls.Add(this.buttonGraphSave);
            this.Controls.Add(this.comboBoxGraphView);
            this.Controls.Add(this.chart);
            this.Name = "GraphViewer";
            this.Text = "GraphViewer";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBoxGraphView;
        private System.Windows.Forms.Button buttonGraphSave;
        private System.Windows.Forms.ComboBox comboBoxXaxis;
        private System.Windows.Forms.ComboBox comboBoxYaxis;
        private System.Windows.Forms.Label labelXvalue;
        private System.Windows.Forms.Label labelYAxisValue;
    }
}