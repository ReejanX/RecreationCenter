using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.IO;
using System.Text.RegularExpressions;

namespace Ticketing_System
{
    public partial class AddVisitors : UserControl
    {
        int num = 1;
        public AddVisitors()
        {
            InitializeComponent();
            
            string dat = Utility.ReadFromFile();
            
            if (dat != null) 
            {
                List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(dat);
                load_datas();
                var idnum = (from t in Lstdata
                            orderby t.VisitorsId descending
                            select new
                            {
                                num = t.VisitorsId
                            }).FirstOrDefault();
                num = Convert.ToInt32(idnum.num) + 1;
            }
            
            txtVisitorID.Text = num.ToString();
            
        }

        private void btnVisitorSave_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0]*$");
            var regexInt = new Regex("^[0-9]");

            if (txtVisitorID.Text == "" || regexItem.IsMatch(txtVisitorID.Text.ToString()) == true)
            {
                MessageBox.Show("Please provide ID", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtVisitorName.Text == "" || regexInt.IsMatch(txtVisitorName.Text.ToString()) == true)
            {
                MessageBox.Show("Please provide Name", "Invalid Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regexItem.IsMatch(txtNumber.Text.ToString()) == true) 
            {
                MessageBox.Show("Please provide Number", "Invalid Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboAge.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select Age Group", "Invalid Age Group",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboCount.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select Group", "Invalid Group",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (DateTime.Parse(txtDate.Text) != DateTime.Now.Date)
            {
                MessageBox.Show("Please provide valid Date", "Invalid Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                int ID = int.Parse(txtVisitorID.Text);
                string name = txtVisitorName.Text;
                Int64? phone = Int64.Parse(txtNumber.Text);
                string ageGroup = comboAge.SelectedItem.ToString();
                int group = int.Parse(comboCount.SelectedItem.ToString());
                DateTime date = DateTime.Parse(txtDate.Text);
                DateTime intime = DateTime.Parse(txtInTime.Text);
                if (group == 0)
                {
                    MessageBox.Show("Please select Group", "Invalid Group",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VisitorsData dataVisitors = new VisitorsData();
                    dataVisitors.VisitorsId = ID;
                    dataVisitors.VisitorName = name;
                    dataVisitors.phone = phone;
                    dataVisitors.AgeGroup = ageGroup;
                    dataVisitors.GroupCount = group;
                    dataVisitors.Date = date;
                    dataVisitors.InTime = intime;
                    

                    List<VisitorsData> visits = new List<VisitorsData>();

                    string datas = Utility.ReadFromFile();
                    if (datas != null && datas != "")
                    {
                        visits = JsonConvert.DeserializeObject<List<VisitorsData>>(datas);
                    }
                    visits.Add(dataVisitors);
                    string strData = JsonConvert.SerializeObject(visits);
                    Utility.WriteToFile(strData);
                    
                    MessageBox.Show("Data Added", "New Visitor Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    num++;
                    txtVisitorID.Text = num.ToString();
                    load_datas();
                }
            }
        }

        private void load_datas()
        {
            string data = Utility.ReadFromFile();
            List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
            
            var column = from t in Lstdata
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
            VisitorsDataGrid.DataSource = column.ToList();
            
        }
        private void clear()
        {
            txtVisitorID.Text = String.Empty;
            txtVisitorName.Text = String.Empty;
            txtNumber.Text = String.Empty;

            comboAge.SelectedItem = null;
            comboCount.SelectedItem = null;
            txtDate.Value = DateTime.Now;
            txtInTime.Value = DateTime.Now;
            

        }

        
    }
}
