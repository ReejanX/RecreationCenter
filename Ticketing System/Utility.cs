using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public static class Utility
    {

        private const string VISITOR_FILE = "visitors.txt";
        public static string WriteToFile(string data) { 
            if (!File.Exists(VISITOR_FILE))
            {
                using (File.Create(VISITOR_FILE)) ;
            }
            using (StreamWriter outputFile = new StreamWriter(VISITOR_FILE,false))
            { 
                outputFile.WriteLine(data);
            }
            return "success";
        }
        public static string ReadFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                string data;
                using (StreamReader r = new StreamReader(path))
                {
                    data = r.ReadToEnd();

                }
                if (data != "")
                {
                    data = "[" + data + "]";

                }
                return data;

            }
            return null;
        }
        public static void WriteToTextFile(string path, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();

            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (!append)
                {

                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    data = data.Trim().Substring(0, data.Trim().Length - 1);

                }
                if (count != 0)
                {
                    data = data + ",";
                }
                writer.WriteLine(data);
            }
        }
        public static string ReadFromFile()
        {
            if (File.Exists(VISITOR_FILE))
            {
                string data = File.ReadAllText(VISITOR_FILE);

                return data;
            }
            return null;
        }
        public static string ReadFromFile(string fileName )
        {
            if (File.Exists(fileName))
            {
                string data = File.ReadAllText(fileName);

                return data;
            }
            return null;
        }
        public static void ExitApp() {
            DialogResult dialog = MessageBox.Show("Do you really want to exit this program?",
                "Exit?", MessageBoxButtons.OKCancel);
            if (dialog== DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
    }
    

}


