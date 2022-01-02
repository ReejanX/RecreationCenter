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
using System.Xml.Serialization;

namespace Ticketing_System
{
    public partial class Staff_Login : Form
    {
        List<Employee> EList;
        XmlSerializer XmlSerializer;
        private int email_index = -1;
        private string pass_in = "";
        public Staff_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }
        public void clearErrorMessages()
        {
            errUsername.Text = "";
            errPassword.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearErrorMessages();
            EList = new List<Employee>();
            XmlSerializer = new XmlSerializer(typeof(List<Employee>));
            FileStream file = new FileStream("C:/file/employeeList.xml", FileMode.Open, FileAccess.Read);
            string username = txtUsername.Text;
            string password = txtPassword.Text;

                

            EList = (List<Employee>)XmlSerializer.Deserialize(file);

            if (username == "")
            {
                errUsername.Text = "* Email is Required.";
            }
            if (password == "")
            {
                errPassword.Text = "* Password is Required.";

            }
            if (username != "" && password != "")
            {
                for (int i = 0; i < EList.Count; i++)
                {
                    if (EList[i].UserName == username)
                    {
                        email_index = i;
                        break;
                    }

                }
                if (email_index == -1)
                {
                    MessageBox.Show("Invalid Login Credentials", "Error");
                }
                else
                {
                    pass_in = EList[email_index].Password;

                    if (pass_in != password)
                    {
                        MessageBox.Show("Invalid Login Credentials", "Error");
                    }
                    else
                    {
                        this.Hide();
                        staffPanel newForm = new staffPanel();
                        newForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            Form2 loginPage = new Form2();
            loginPage.ShowDialog();
           
        }
    }
}


