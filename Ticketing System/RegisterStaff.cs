using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ticketing_System
{
    public partial class RegisterStaff : UserControl
    {
        
        
        List<Employee> staffregister;
        public XmlSerializer xmlSerializer;
        Boolean isUserNameValid, isUsernameValid, isEmailValid, isAddressValid, isPasswordValid, isPhoneValid;
        const string FILEPATH = "C:/file/employeeList.xml";
        public void readData()
            {

            if (File.Exists(FILEPATH))
            {
                FileStream fileStream = new FileStream(FILEPATH, FileMode.Open, FileAccess.Read);
                try
                {
                    var employee = xmlSerializer.Deserialize(fileStream);

                    staffregister = (List<Employee>)employee;
                    dataGridView1.DataSource = staffregister;
                    fileStream.Close();
                }
                catch (Exception e)
                {
                    fileStream.Close();
                    MessageBox.Show("Failed to Load Employee, File Corrupted.", "Failed", MessageBoxButtons.OK);
                }
            }
            }
        public RegisterStaff()
        {
            InitializeComponent();
            staffregister = new List<Employee>();
            xmlSerializer = new XmlSerializer(typeof(List<Employee>));

            readData();
            
        }


        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            clearErrorMessage();

            if (userNameTxtBox.Text.Length == 0)
            {
                userNameTxtBox.Focus();
                errUsername.Text = "* UserName is Required";
                 isUserNameValid = false;
            }
            else
            {
                isUserNameValid = true;
            }
            if (fullNameTxtBox.Text.Length == 0)
            {
                fullNameTxtBox.Focus();
                errFullName.Text = "*Full Name is Required";
                isUsernameValid = false;

            }
            else
            {
                isUsernameValid = true;
            }
            if (emailTxtBox.Text.Length == 0)
            {
                emailTxtBox.Focus();
                EmailError.Text = "* Email is Required";
                isEmailValid = false;
            }
            else if (!Regex.IsMatch(emailTxtBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                EmailError.Text = " Enter a valid email.";
                emailTxtBox.Select(0, emailTxtBox.Text.Length);
                emailTxtBox.Focus();
                isEmailValid = false;
            }
            else
            {
                isEmailValid = true;
            }

            if (addressTxtBox.Text.Length == 0)
            {
                addressTxtBox.Focus();
                errAddress.Text = "* Address is Required";
                isAddressValid = false;

            }
            else
            {
                isAddressValid = true;
            }

            if (phoneNumberTxtBox.Text.Length == 0)
            {
                phoneNumberTxtBox.Focus();
                errPhoneNumber.Text = "* Phone is Required";
                isPhoneValid = false;
            }
            else
            {
                isPhoneValid = true;
            }
            if (passwordTxtBox.Text.Length == 0)
            {
                passwordTxtBox.Focus();
                errPassword.Text = "*Password is Required";
                isPasswordValid = false;
            }
            else
            {
                isPasswordValid = true;
            }

            if (isEmailValid && isUserNameValid && isUsernameValid && isAddressValid && isPasswordValid && isEmailValid && isPhoneValid)
            {

                if (!checkIfUsername(userNameTxtBox.Text.Trim()))
                {
                    //Initializing a new FileStream to create and write data from the XML
                    FileStream fileStream = new FileStream("C:/file/employeeList.xml", FileMode.Open, FileAccess.ReadWrite);
                    //Create a new Employee object
                    Employee staff = new Employee();


                    //Input the Entered values into the UserDetails Object
                    staff.UserName = userNameTxtBox.Text;
                    staff.Fullname = fullNameTxtBox.Text;
                    staff.Email = emailTxtBox.Text;
                    staff.Password = passwordTxtBox.Text;
                    staff.Address = addressTxtBox.Text;
                    staff.PhoneNumber = phoneNumberTxtBox.Text;

                    //Add the UserDetails object into the list
                    staffregister.Add(staff);

                  
                    xmlSerializer.Serialize(fileStream, staffregister);
                    fileStream.Close();
                   

                    DialogResult result = MessageBox.Show("User Registered!", "Registration Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    readData();
                    
                }
                
                else
                {
                    MessageBox.Show("User Already Exist!", "Registeration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearErrorMessage();

                }
            }
        }

        public void clearErrorMessage()
        {
            errUsername.Text = "";
            errPassword.Text = "";
            errPhoneNumber.Text = "";
            EmailError.Text = "";
            errAddress.Text = "";
            errFullName.Text = "";
        }
        private Boolean checkIfUsername(string Username)
        {
            if (staffregister == null) { return false; }
            foreach (var x in staffregister)
            {
                if (x.UserName == Username)
                {
                    return true;
                }

            }
            return false;

        }
        private Boolean checkAdminUserName(string Username)
        {
            if (Username == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
