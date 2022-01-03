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
    public partial class AddPrice : UserControl
    {
        private const string FILE_NAME = "price.txt";
        int num = 1;
        public AddPrice()
        {
            InitializeComponent();
            string dat = Utility1.ReadFromTextFile(FILE_NAME);
            


            if (dat == null || dat =="[\r\n]")
            {
                txtPriceID.Text = num.ToString();
            }
            else
            {
                List<PriceData> Lstdata = JsonConvert.DeserializeObject<List<PriceData>>(dat);
                //load_data();
                BindGrid();
                var idnum = (from t in Lstdata
                             orderby t.PriceID descending
                             select new
                             {
                                 num = t.PriceID
                             }).FirstOrDefault();
                num = Convert.ToInt32(idnum.num) + 1;
                txtPriceID.Text = num.ToString();
            }
            

            

        }

        

        private void btnedit_Click(object sender, EventArgs e)
        {
            PriceData priceData = new PriceData();
            if (txtGroupCount.SelectedIndex == -1 && txtDuration.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Box", "Empty Selection Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtchildWeek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekdays Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtchildWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdultweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdultWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                priceData.PriceID = int.Parse(txtPriceID.Text);
                priceData.Duration= int.Parse(txtDuration.SelectedItem.ToString());
                priceData.GroupCount = int.Parse(txtGroupCount.SelectedItem.ToString());
                priceData.WeekDaysChildPrice = int.Parse(txtchildWeek.Text);
                priceData.WeekendChildPrice = int.Parse(txtchildWeekend.Text);
                priceData.WeekDaysAdultPrice = int.Parse(txtAdultweek.Text);
                priceData.WeekendAdultPrice = int.Parse(txtAdultWeekend.Text);
                
                priceData.Edit(priceData);
              
                MessageBox.Show("Data Edit", "Price Edited",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
            }
        }

        private void btnPriceSave_Click(object sender, EventArgs e)
        {
            
            int dur = 0;
            if (txtGroupCount.SelectedIndex == -1 && txtDuration.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Box", "Empty Selection Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtchildWeek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekdays Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtchildWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdultweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdultWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {

                if (txtDuration.SelectedItem.ToString() == "4>")
                {
                    dur = 5;
                }
                else
                {
                    dur = int.Parse(txtDuration.SelectedItem.ToString());
                }
                int priceId = int.Parse(txtPriceID.Text);
                int group = int.Parse(txtGroupCount.SelectedItem.ToString());
                int childweek = int.Parse(txtchildWeek.Text);
                int childweekend = int.Parse(txtchildWeekend.Text);
                int adultweek = int.Parse(txtAdultweek.Text);
                int adultweekend = int.Parse(txtAdultWeekend.Text);
               
                PriceData prices = new PriceData();
                prices.PriceID = priceId;
                prices.GroupCount = group;
                prices.Duration = dur;
                prices.WeekDaysChildPrice = childweek;
                prices.WeekendChildPrice = childweekend;
                prices.WeekDaysAdultPrice = adultweek;
                prices.WeekendAdultPrice = adultweekend;
                

                prices.Add(prices);
                


                //List<PriceData> pricedata = new List<PriceData>();

                //string dat = Utility1.ReadFromFile();
                //if (dat != null && dat != "")
                //{
                //    pricedata = JsonConvert.DeserializeObject<List<PriceData>>(dat);
                //}
                //pricedata.Add(prices);
                //string priceData = JsonConvert.SerializeObject(pricedata);
                //Utility1.WriteToFile(priceData);
                MessageBox.Show("New Price List Added","Data Added" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                num++;
                txtPriceID.Text = num.ToString();
                BindGrid();
                //ResetForm();

            }

       

        }
       //public void ResetForm()
       // {
       //     AddPrice addPrice = new AddPrice();
       //     addPrice.Refresh();
       // }
        public void clear()
        {
            txtGroupCount.SelectedItem = null;
            txtDuration.SelectedItem = null;
            txtchildWeek.Text = string.Empty;
            txtchildWeekend.Text = string.Empty;
            txtAdultweek.Text = string.Empty;
            txtAdultWeekend.Text = string.Empty;
            

        }
        private void BindGrid()
        {
            PriceData obj = new PriceData();
            List<PriceData> listStudents = obj.List();
            DataTable dt = Utility1.ConvertToDataTable(listStudents);
            pricedata.DataSource = dt;
           
        }
        private void load_data()
        {
            string dat = Utility1.ReadFromFile();
            List<PriceData> Lstdata = JsonConvert.DeserializeObject<List<PriceData>>(dat);
            if (Lstdata == null) { }
            var columns = from t in Lstdata
                          orderby t.GroupCount
                          select new
                          {
                              PriceID = t.PriceID,
                              Group = t.GroupCount,
                              Duration = t.Duration,
                              ChildWeekPrice = t.WeekDaysChildPrice,
                              ChildWeekendPrice = t.WeekendChildPrice,
                              AdultWeekPrice = t.WeekDaysAdultPrice,
                              AdultWeekendPrice = t.WeekendAdultPrice,


                          };
            pricedata.DataSource = columns.ToList();

        }

        private void pricedata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PriceData priceObj = new PriceData();

            if (e.ColumnIndex == 0)
            {
                string value = pricedata[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    PriceData priceData = priceObj.List().Where(x => x.PriceID == id).FirstOrDefault();
                    txtPriceID.Text = priceData.PriceID.ToString();
                    txtDuration.Text = priceData.Duration.ToString();
                    txtGroupCount.Text = priceData.GroupCount.ToString();
                    txtAdultweek.Text = priceData.WeekDaysAdultPrice.ToString();
                    txtAdultWeekend.Text = priceData.WeekendAdultPrice.ToString();
                    txtchildWeek.Text = priceData.WeekDaysChildPrice.ToString();
                    txtchildWeekend.Text = priceData.WeekendChildPrice.ToString();
                    
                    btnPriceSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnCancel.Visible = true;

                }
            }
            else if (e.ColumnIndex == 1) {
                string message = "Do you want to Delete this Record?";
                string title = "Delete Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {

                    string value = pricedata[2, e.RowIndex].Value.ToString();
                    priceObj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("Record Successfully Deleted");
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
