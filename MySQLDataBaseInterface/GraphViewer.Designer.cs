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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxGraphView = new System.Windows.Forms.ComboBox();
            this.buttonGraphSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(13, 39);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "value1";
            this.chart.Series.Add(series2);
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
            this.buttonGraphSave.Location = new System.Drawing.Point(699, 360);
            this.buttonGraphSave.Name = "buttonGraphSave";
            this.buttonGraphSave.Size = new System.Drawing.Size(97, 34);
            this.buttonGraphSave.TabIndex = 2;
            this.buttonGraphSave.Text = "SAVE";
            this.buttonGraphSave.UseVisualStyleBackColor = true;
            this.buttonGraphSave.Click += new System.EventHandler(this.buttonGraphSave_Click);
            // 
            // GraphViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 406);
            this.Controls.Add(this.buttonGraphSave);
            this.Controls.Add(this.comboBoxGraphView);
            this.Controls.Add(this.chart);
            this.Name = "GraphViewer";
            this.Text = "GraphViewer";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBoxGraphView;
        private System.Windows.Forms.Button buttonGraphSave;
    }
}