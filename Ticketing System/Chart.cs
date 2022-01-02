using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ticketing_System
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            try
            {
                pricechart(Report.dates);
            }
            catch
            {
                MessageBox.Show("No Data Found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pricechart(DateTime date)
        {

            int indate = ((int)date.DayOfWeek);
            DateTime fDate = date.AddDays(-indate);
            DateTime LDate = date.AddDays((7 - indate));
            string data = Utility.ReadFromFile("visitors.txt");
            List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
            DataTable dt = new DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("Total Visitors");
            dt.Columns.Add("Total Earning");
            dt.Rows.Add("Sunday", Lstdata
                          .Where(a => a.Date == fDate).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate).Select(a => a.Price).Sum());
            dt.Rows.Add("Monday", Lstdata
                          .Where(a => a.Date == fDate.AddDays(1)).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate.AddDays(1)).Select(a => a.Price).Sum());
            dt.Rows.Add("Tuesday", Lstdata
                          .Where(a => a.Date == fDate.AddDays(2)).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate.AddDays(2)).Select(a => a.Price).Sum());
            dt.Rows.Add("Wednesday", Lstdata
                          .Where(a => a.Date == fDate.AddDays(3)).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate.AddDays(3)).Select(a => a.Price).Sum());
            dt.Rows.Add("Thrusday", Lstdata
                          .Where(a => a.Date == fDate.AddDays(4)).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate.AddDays(4)).Select(a => a.Price).Sum());
            dt.Rows.Add("Friday", Lstdata
                          .Where(a => a.Date == fDate.AddDays(5)).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == fDate.AddDays(5)).Select(a => a.Price).Sum());
            dt.Rows.Add("Saturday", Lstdata
                          .Where(a => a.Date == LDate).Select(a => a.GroupCount).Sum(), Lstdata
                          .Where(a => a.Date == LDate).Select(a => a.Price).Sum());

            chart2.Series["Series1"].LegendText = "Total Earnings";
            chart2.Series["Series1"].ChartType = SeriesChartType.Column;
            chart2.Series["Series1"].IsValueShownAsLabel = true;
            chart2.Series["Series1"].XValueMember = "Day";
            chart2.Series["Series1"].YValueMembers = "Total Earning";
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart2.DataSource = dt;

            chart1.Series["Series1"].LegendText = "Total Visitors";
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].XValueMember = "Day";
            chart1.Series["Series1"].YValueMembers = "Total Visitors";
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.DataSource = dt;

        }
    }
}
