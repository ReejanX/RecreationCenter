using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    class ExportHelper
    {
        public bool Export(DataGridView dataGridView)
        {
            bool exported = false;
            List<string> lines = new List<string>();
            DataGridViewColumnCollection header = dataGridView.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();
            foreach (DataGridViewColumn cols in header)
            {
                if (!firstDone)
                {

                    headerLine.Append(cols.DataPropertyName);
                    firstDone = true;
                }
                else
                {
                    headerLine.Append("," + cols.DataPropertyName);

                }
                

            }
            lines.Add(headerLine.ToString());
            foreach(DataGridViewRow row in dataGridView.Rows)
            {

                StringBuilder dataLine = new StringBuilder();
                firstDone = false;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {

                        dataLine.Append("," + cell.Value);
                    }

                }
                lines.Add(dataLine.ToString());
            }

            string file = "exportedCSV.csv";
            System.IO.File.WriteAllLines(file, lines);
            MessageBox.Show("Data exported to exportedCSV.file", "Export Successful",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(file);
            return exported;
        }
        public void BindData(string filePath, DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }

        }
    }
}
