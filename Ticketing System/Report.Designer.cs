﻿
namespace Ticketing_System
{
    partial class Report
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.SearchDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.ageddata = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWeeklyChart = new System.Windows.Forms.Button();
            this.btnVisitorSort = new System.Windows.Forms.Button();
            this.btnEarningSort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageddata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWeekly.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(590, 150);
            this.btnWeekly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(264, 98);
            this.btnWeekly.TabIndex = 1;
            this.btnWeekly.Text = "Weekly Report";
            this.btnWeekly.UseVisualStyleBackColor = false;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDaily.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(4, 150);
            this.btnDaily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(248, 88);
            this.btnDaily.TabIndex = 2;
            this.btnDaily.Text = "Daily Report";
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // SearchDate
            // 
            this.SearchDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchDate.CustomFormat = "dd-MMM-yyyy";
            this.SearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchDate.Location = new System.Drawing.Point(109, 86);
            this.SearchDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchDate.Name = "SearchDate";
            this.SearchDate.Size = new System.Drawing.Size(256, 38);
            this.SearchDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(590, 330);
            this.ReportDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.RowTemplate.Height = 24;
            this.ReportDataGrid.Size = new System.Drawing.Size(878, 566);
            this.ReportDataGrid.TabIndex = 6;
            // 
            // ageddata
            // 
            this.ageddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ageddata.Location = new System.Drawing.Point(4, 330);
            this.ageddata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageddata.Name = "ageddata";
            this.ageddata.RowHeadersWidth = 51;
            this.ageddata.RowTemplate.Height = 24;
            this.ageddata.Size = new System.Drawing.Size(576, 561);
            this.ageddata.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Daily Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weekly Report";
            // 
            // btnWeeklyChart
            // 
            this.btnWeeklyChart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWeeklyChart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyChart.Location = new System.Drawing.Point(862, 150);
            this.btnWeeklyChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWeeklyChart.Name = "btnWeeklyChart";
            this.btnWeeklyChart.Size = new System.Drawing.Size(264, 98);
            this.btnWeeklyChart.TabIndex = 10;
            this.btnWeeklyChart.Text = "Weekly Chart";
            this.btnWeeklyChart.UseVisualStyleBackColor = false;
            this.btnWeeklyChart.Click += new System.EventHandler(this.btnWeeklyChart_Click);
            // 
            // btnVisitorSort
            // 
            this.btnVisitorSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorSort.Location = new System.Drawing.Point(1054, 269);
            this.btnVisitorSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisitorSort.Name = "btnVisitorSort";
            this.btnVisitorSort.Size = new System.Drawing.Size(142, 52);
            this.btnVisitorSort.TabIndex = 11;
            this.btnVisitorSort.Text = "Vistiors";
            this.btnVisitorSort.UseVisualStyleBackColor = true;
            this.btnVisitorSort.Click += new System.EventHandler(this.btnVisitorSort_Click);
            // 
            // btnEarningSort
            // 
            this.btnEarningSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarningSort.Location = new System.Drawing.Point(1204, 269);
            this.btnEarningSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEarningSort.Name = "btnEarningSort";
            this.btnEarningSort.Size = new System.Drawing.Size(160, 52);
            this.btnEarningSort.TabIndex = 12;
            this.btnEarningSort.Text = "Earnings";
            this.btnEarningSort.UseVisualStyleBackColor = true;
            this.btnEarningSort.Click += new System.EventHandler(this.btnEarningSort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(916, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sort By:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEarningSort);
            this.Controls.Add(this.btnVisitorSort);
            this.Controls.Add(this.btnWeeklyChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageddata);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchDate);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1472, 896);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageddata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.DateTimePicker SearchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.DataGridView ageddata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWeeklyChart;
        private System.Windows.Forms.Button btnVisitorSort;
        private System.Windows.Forms.Button btnEarningSort;
        private System.Windows.Forms.Label label5;
    }
}
