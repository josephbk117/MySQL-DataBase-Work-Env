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
        public GraphViewer(DataGridViewRowCollection rows)
        {
            InitializeComponent();
            foreach (DataGridViewRow col in rows)
            {
                if (col.Cells[1].Value != null)
                    chart.Series["value1"].Points.AddXY(col.Cells[1].Value, col.Cells[5].Value);
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
    }
}
