using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class Exit_Visitor : UserControl
    {
        private const string VISITOR = "visitors.txt";
        private const string PRICE = "price.txt";
        public Exit_Visitor()
        {
            InitializeComponent();
            string dat = Utility.ReadFromFile();

            if (dat != null) { load_data(); }

        }




        private void btnVisitorExit_Click(object sender, EventArgs e)
        {
            if (txtVisitorsID.Text == "")
            {
                MessageBox.Show("Please provide ID", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int visID = int.Parse(txtVisitorsID.Text);
                DateTime outtime = DateTime.Parse(txtOutTime.Text);
                string data = Utility.ReadFromFile();
                List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
                int index = Lstdata.FindIndex(x => x.VisitorsId == visID);
                Lstdata[index].Price = int.Parse(txtPrice.Text);
                Lstdata[index].OutTime = outtime;

                string dt = JsonConvert.SerializeObject(Lstdata);
                Utility.WriteToFile(dt);
                MessageBox.Show("Customer Fee Updated", "Visitor Exit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int visID = int.Parse(txtVisitorsID.Text);
                DateTime outtime = DateTime.Parse(txtOutTime.Text);
                string data = Utility.ReadFromFile();
                List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
                var columns = from t in Lstdata
                              where t.VisitorsId == visID
                              select new
                              {
                                  AgeGroup = t.AgeGroup,
                                  GroupCount = t.GroupCount,
                                  Date = t.Date,
                                  In_Time = t.InTime,
                              };
                var datas = columns.ToList();
                string age = datas[0].AgeGroup;
                int count = datas[0].GroupCount;
                DateTime todayDate = datas[0].Date;
                DateTime arrival = datas[0].In_Time;
                int durat = (int)Math.Round(double.Parse((outtime.Subtract(arrival).TotalHours).ToString()));
                txtDuration.Text = (durat).ToString();
                if (durat < 1)
                {
                    durat = 1;
                }
                if (durat > 4)
                {
                    durat = 5;
                }
                try
                {
                    txtPrice.Text = (calculatePrice(durat, count, todayDate, age)).ToString();
                    MessageBox.Show("User Ticket Free Calculated", "Calculation Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Empty Price Data", "Invalid Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
                
            }
            catch
            {
                MessageBox.Show("Please Provide a ID", "Empty ID",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clear()
        {
            txtVisitorsID.Text = String.Empty;

            txtPrice.Text = String.Empty;
            txtDuration.Text = String.Empty;

            txtOutTime.Value = DateTime.Now;

        }
        private int calculatePrice(int duration, int count, DateTime week, string age)
        {
            int price = 0;
            string data = Utility1.ReadFromTextFile(PRICE);
            int indate = ((int)week.DayOfWeek);
            List<PriceData> ratedata = JsonConvert.DeserializeObject<List<PriceData>>(data);
            var pricedata = from t in ratedata
                            select new
                            {

                                Childweekend = t.WeekendChildPrice,
                                Childweekdays = t.WeekDaysChildPrice,
                                Adultweekdays = t.WeekDaysAdultPrice,
                                Adultweekend = t.WeekendAdultPrice,

                            };
            var actualprice = pricedata.ToList();

            if (age == "Child")
            {
                if (indate == 1 || indate == 7)
                {
                    price = actualprice[0].Childweekend;
                }
                else
                {
                    price = actualprice[0].Childweekdays;
                }
            }
            else if (age == "Adult")
            {
                if (indate == 1 || indate == 7)
                {
                    price = actualprice[0].Adultweekend;
                }
                else
                {
                    price = actualprice[0].Adultweekdays;
                }
            }
            

            int finalprice = price * count;
            return finalprice;
        }
    

    private void load_data()
    {
        string data = Utility.ReadFromFile();
        List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);

        var columns = from t in Lstdata
                      where t.Date == DateTime.Today
                      orderby t.VisitorsId
                      select new
                      {
                          VisitorsID = t.VisitorsId,
                          Name = t.VisitorName,
                          Phone = t.phone,
                          AgeGroup = t.AgeGroup,
                          GroupCount = t.GroupCount,
                          Date = t.Date,
                          In_Time = t.InTime,
                          Out_Time = t.OutTime,
                          Price = t.Price,

                      };
        VisitorsExitDataGrid.DataSource = columns.ToList();

    }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new ExportHelper().Export(VisitorsExitDataGrid);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
            new ExportHelper().BindData(openFileDialog1.FileName,VisitorsExitDataGrid);
        }
    }
}
