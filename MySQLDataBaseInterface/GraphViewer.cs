using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLDataBaseInterface
{
    public partial class GraphViewer : Form
    {
        Dictionary<int, string> dCols = new Dictionary<int, string>();
        DataGridViewColumnCollection columns;
        DataGridViewRowCollection rows;
        
        
        public GraphViewer(DataGridViewRowCollection rows,DataGridViewColumnCollection columns)
        {
            //get columns
            this.columns = columns;
            this.rows = rows;

            InitializeComponent();

           

            int index = 0;
            foreach (DataGridViewColumn col in columns)
            {
                dCols.Add(index, col.Name);
                index++;
            }
            for (int i = 0; i < dCols.Count; i++)
            {
                Console.WriteLine("Dic contains : " + dCols[i]);
                comboBoxXaxis.Items.Add(dCols[i]);
                comboBoxYaxis.Items.Add(dCols[i]);
            }
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value != null)
                    chart.Series["value1"].Points.AddXY(row.Cells[1].Value, row.Cells[5].Value);
            }            
        }

        private void comboBoxGraphView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGraphView.SelectedIndex == 0)
            {
                chart.Series["value1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart.ChartAreas["ChartArea1"].AxisY.Interval = 1;
            }
            if (comboBoxGraphView.SelectedIndex == 1)
            {
                chart.Series["value1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            if (comboBoxGraphView.SelectedIndex == 2)
            {
                chart.Series["value1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }            
        }

        private void buttonGraphSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                chart.SaveImage(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void comboBoxXaxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get index of combo box match with the key value and et as x Axis
            //Common for both
            chart.Series["value1"].Points.Clear();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value != null && comboBoxYaxis.SelectedIndex >= 0 && comboBoxXaxis.SelectedIndex >= 0)
                {
                    
                    chart.Series["value1"].Points.AddXY(row.Cells[comboBoxXaxis.SelectedIndex].Value,
                        row.Cells[comboBoxYaxis.SelectedIndex].Value);
                }
            }
        }
    }
}
