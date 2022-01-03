
namespace Ticketing_System
{
    partial class AddPrice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGroupCount = new System.Windows.Forms.ComboBox();
            this.txtDuration = new System.Windows.Forms.ComboBox();
            this.txtchildWeekend = new System.Windows.Forms.TextBox();
            this.txtchildWeek = new System.Windows.Forms.TextBox();
            this.txtAdultWeekend = new System.Windows.Forms.TextBox();
            this.txtAdultweek = new System.Windows.Forms.TextBox();
            this.btnPriceSave = new System.Windows.Forms.Button();
            this.pricedata = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPriceID = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricedata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(77, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(77, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(468, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Child";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(597, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weekend";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(798, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weekday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(468, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adult";
            // 
            // txtGroupCount
            // 
            this.txtGroupCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGroupCount.FormattingEnabled = true;
            this.txtGroupCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15"});
            this.txtGroupCount.Location = new System.Drawing.Point(251, 219);
            this.txtGroupCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupCount.Name = "txtGroupCount";
            this.txtGroupCount.Size = new System.Drawing.Size(180, 33);
            this.txtGroupCount.TabIndex = 8;
            // 
            // txtDuration
            // 
            this.txtDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDuration.FormattingEnabled = true;
            this.txtDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "4>"});
            this.txtDuration.Location = new System.Drawing.Point(251, 288);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(180, 33);
            this.txtDuration.TabIndex = 9;
            // 
            // txtchildWeekend
            // 
            this.txtchildWeekend.Location = new System.Drawing.Point(581, 163);
            this.txtchildWeekend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtchildWeekend.Name = "txtchildWeekend";
            this.txtchildWeekend.Size = new System.Drawing.Size(148, 31);
            this.txtchildWeekend.TabIndex = 10;
            // 
            // txtchildWeek
            // 
            this.txtchildWeek.Location = new System.Drawing.Point(804, 161);
            this.txtchildWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtchildWeek.Name = "txtchildWeek";
            this.txtchildWeek.Size = new System.Drawing.Size(148, 31);
            this.txtchildWeek.TabIndex = 11;
            // 
            // txtAdultWeekend
            // 
            this.txtAdultWeekend.Location = new System.Drawing.Point(581, 242);
            this.txtAdultWeekend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdultWeekend.Name = "txtAdultWeekend";
            this.txtAdultWeekend.Size = new System.Drawing.Size(148, 31);
            this.txtAdultWeekend.TabIndex = 12;
            // 
            // txtAdultweek
            // 
            this.txtAdultweek.Location = new System.Drawing.Point(804, 242);
            this.txtAdultweek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdultweek.Name = "txtAdultweek";
            this.txtAdultweek.Size = new System.Drawing.Size(148, 31);
            this.txtAdultweek.TabIndex = 13;
            // 
            // btnPriceSave
            // 
            this.btnPriceSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPriceSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceSave.Location = new System.Drawing.Point(83, 365);
            this.btnPriceSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPriceSave.Name = "btnPriceSave";
            this.btnPriceSave.Size = new System.Drawing.Size(148, 58);
            this.btnPriceSave.TabIndex = 16;
            this.btnPriceSave.Text = "Save";
            this.btnPriceSave.UseVisualStyleBackColor = false;
            this.btnPriceSave.Click += new System.EventHandler(this.btnPriceSave_Click);
            // 
            // pricedata
            // 
            this.pricedata.BackgroundColor = System.Drawing.Color.Silver;
            this.pricedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricedata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.pricedata.Location = new System.Drawing.Point(39, 449);
            this.pricedata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pricedata.Name = "pricedata";
            this.pricedata.RowHeadersWidth = 51;
            this.pricedata.RowTemplate.Height = 24;
            this.pricedata.Size = new System.Drawing.Size(1372, 578);
            this.pricedata.TabIndex = 18;
            this.pricedata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricedata_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 10;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(603, 365);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 58);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtPriceID
            // 
            this.txtPriceID.Location = new System.Drawing.Point(251, 157);
            this.txtPriceID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceID.Name = "txtPriceID";
            this.txtPriceID.Size = new System.Drawing.Size(180, 31);
            this.txtPriceID.TabIndex = 21;
            // 
            // priceTxt
            // 
            this.priceTxt.AutoSize = true;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceTxt.Location = new System.Drawing.Point(77, 160);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(111, 31);
            this.priceTxt.TabIndex = 20;
            this.priceTxt.Text = "Price ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(803, 365);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 58);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(283, 365);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 58);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPriceID);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pricedata);
            this.Controls.Add(this.btnPriceSave);
            this.Controls.Add(this.txtAdultweek);
            this.Controls.Add(this.txtAdultWeekend);
            this.Controls.Add(this.txtchildWeek);
            this.Controls.Add(this.txtchildWeekend);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtGroupCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPrice";
            this.Size = new System.Drawing.Size(1444, 1052);
            ((System.ComponentModel.ISupportInitialize)(this.pricedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGroupCount;
        private System.Windows.Forms.ComboBox txtDuration;
        private System.Windows.Forms.TextBox txtchildWeekend;
        private System.Windows.Forms.TextBox txtchildWeek;
        private System.Windows.Forms.TextBox txtAdultWeekend;
        private System.Windows.Forms.TextBox txtAdultweek;
        private System.Windows.Forms.Button btnPriceSave;
        private System.Windows.Forms.DataGridView pricedata;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPriceID;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}
