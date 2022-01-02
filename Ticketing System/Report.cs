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

namespace Ticketing_System
{
    public partial class Report : UserControl
    {
        private const string VISITOR = "vistors.txt";
        public static DateTime dates = DateTime.Now;
        public Report()
        {
            InitializeComponent();      
        }

        private void load_data(DateTime date)
        {
            string data = Utility.ReadFromFile();
            List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Count");
            dt.Rows.Add("Child Group 1", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Child" && a.GroupCount == 1).Count());
            dt.Rows.Add("Adult Group 1" , Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Adult" && a.GroupCount == 1).Count());
            dt.Rows.Add("Aged Group 1",Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Aged" && a.GroupCount == 1).Count());
            dt.Rows.Add("Child Group 2" , Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Child" && a.GroupCount == 2).Count());
            dt.Rows.Add("Adult Group 2" , Lstdata
                          .Where(a => a.Date == date &&  a.AgeGroup == "Adult" && a.GroupCount == 2).Count());
            dt.Rows.Add("Aged Group 2", Lstdata
                          .Where(a => a.Date == date &&  a.AgeGroup == "Aged" && a.GroupCount == 2).Count());
            dt.Rows.Add("Child Group 5", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Child" && a.GroupCount == 5).Count());
            dt.Rows.Add("Adult Group 5", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Adult" && a.GroupCount == 5).Count());
            dt.Rows.Add("Aged Group 5", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Aged" && a.GroupCount == 5).Count());
            dt.Rows.Add("Child Group 10", Lstdata
                          .Where(a => a.AgeGroup == "Child" && a.GroupCount == 10).Count());
            dt.Rows.Add("Adult Group 10" , Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Adult" && a.GroupCount == 10).Count());
            dt.Rows.Add("Aged Group 10" , Lstdata
                          .Where(a => a.AgeGroup == "Aged" && a.GroupCount == 10).Count());
            dt.Rows.Add("Child Group 15", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Child" && a.GroupCount == 15).Count());
            dt.Rows.Add("Adult Group 15", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Adult" && a.GroupCount == 15).Count());
            dt.Rows.Add("Aged Group 15", Lstdata
                          .Where(a => a.Date == date && a.AgeGroup == "Aged" && a.GroupCount == 15).Count());
            ageddata.Refresh();
            ageddata.DataSource = dt;
        }
        private void VisitorsSort_data(DateTime date)
        {
            int indate = ((int)date.DayOfWeek);
            DateTime fDate = date.AddDays(-indate);
            DateTime LDate = date.AddDays((7 - indate));
            string data = Utility.ReadFromFile(VISITOR);
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
            //ReportDataGrid.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = dt.Rows.Count - 1; j > i; j--)
                {
                    if (Convert.ToInt32(dt.Rows[j]["Total Visitors"]) < Convert.ToInt32(dt.Rows[j - 1]["Total Visitors"]))
                    {
                        var temp = dt.Rows[j]["Total Earning"];
                        var visit = dt.Rows[j]["Total Visitors"];
                        var name = dt.Rows[j]["Day"];
                        dt.Rows[j]["Total Earning"] = dt.Rows[j - 1]["Total Earning"];
                        dt.Rows[j - 1]["Total Earning"] = temp;
                        dt.Rows[j]["Total Visitors"] = dt.Rows[j - 1]["Total Visitors"];
                        dt.Rows[j - 1]["Total Visitors"] = visit;
                        dt.Rows[j]["Day"] = dt.Rows[j - 1]["Day"];
                        dt.Rows[j - 1]["Day"] = name;

                    }
                }
            }


            this.ReportDataGrid.DataSource = dt;
        }
        private void EarningsSort_data(DateTime date)
        {
            int indate = ((int)date.DayOfWeek);
            DateTime fDate = date.AddDays(-indate);
            DateTime LDate = date.AddDays((7 - indate));
            string data = Utility.ReadFromFile(VISITOR);
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
            //ReportDataGrid.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = dt.Rows.Count - 1; j > i; j--)
                {
                    if (Convert.ToInt32(dt.Rows[j]["Total Earning"]) < Convert.ToInt32(dt.Rows[j - 1]["Total Earning"]))
                    {
                        var temp = dt.Rows[j]["Total Earning"];
                        var visit = dt.Rows[j]["Total Visitors"];
                        var name = dt.Rows[j]["Day"];
                        dt.Rows[j]["Total Earning"] = dt.Rows[j - 1]["Total Earning"];
                        dt.Rows[j - 1]["Total Earning"] = temp;
                        dt.Rows[j]["Total Visitors"] = dt.Rows[j - 1]["Total Visitors"];
                        dt.Rows[j - 1]["Total Visitors"] = visit;
                        dt.Rows[j]["Day"] = dt.Rows[j - 1]["Day"];
                        dt.Rows[j - 1]["Day"] = name;

                    }
                }
            }


            this.ReportDataGrid.DataSource = dt;
        }
        private void loadweekly_data(DateTime date)
        {
            
            int indate = ((int)date.DayOfWeek);
            DateTime fDate = date.AddDays(-indate);
            DateTime LDate = date.AddDays((7-indate));
            string data = Utility.ReadFromFile();
            List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
            DataTable dt = new DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("Total Visitors");
            dt.Columns.Add("Total Earning");
            dt.Rows.Add("Sunday", Lstdata
                          .Where(a => a.Date == fDate ).Select( a => a.GroupCount).Sum(), Lstdata
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
            //ReportDataGrid.DataSource = dt;            
            this.ReportDataGrid.DataSource = dt;
           

            

        }
            

        private void btnDaily_Click(object sender, EventArgs e)
        {
            
            DateTime currentDate = DateTime.Parse(SearchDate.Text);
            try
            {
                load_data(currentDate);
            }
            catch
            {
                MessageBox.Show("No Data Found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Parse(SearchDate.Text);
            try
            {
                loadweekly_data(currentDate);
            }
            catch
            {
                MessageBox.Show("No Data Found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWeeklyChart_Click(object sender, EventArgs e)
        {
            dates = DateTime.Parse(SearchDate.Text);
            Chart home = new Chart();
            home.Show();
        }

        private void btnVisitorSort_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Parse(SearchDate.Text);
            try
            {
                VisitorsSort_data(currentDate);
            }
            catch
            {
                MessageBox.Show("No Data Found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEarningSort_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Parse(SearchDate.Text);
            try
            {
                EarningsSort_data(currentDate);
            }
            catch
            {
                MessageBox.Show("No Data Found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
