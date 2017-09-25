namespace HRIS_SOFTWARE
{
    partial class MasterSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterSettings));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabMS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvEmp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvgrade = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIcon = new System.Windows.Forms.ImageList(this.components);
            this.tabMS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(792, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(14, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "X";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
            // 
            // tabMS
            // 
            this.tabMS.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMS.Controls.Add(this.tabPage1);
            this.tabMS.Controls.Add(this.tabPage2);
            this.tabMS.Controls.Add(this.tabPage3);
            this.tabMS.Controls.Add(this.tabPage4);
            this.tabMS.Controls.Add(this.tabPage5);
            this.tabMS.Controls.Add(this.tabPage6);
            this.tabMS.Controls.Add(this.tabPage7);
            this.tabMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMS.ImageList = this.imageList1;
            this.tabMS.Location = new System.Drawing.Point(12, 12);
            this.tabMS.Multiline = true;
            this.tabMS.Name = "tabMS";
            this.tabMS.SelectedIndex = 0;
            this.tabMS.Size = new System.Drawing.Size(785, 578);
            this.tabMS.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtAN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtL);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lvEmp);
            this.tabPage1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageKey = "Employee_Management.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 69);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvEmp
            // 
            this.lvEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvEmp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmp.FullRowSelect = true;
            this.lvEmp.GridLines = true;
            this.lvEmp.Location = new System.Drawing.Point(6, 50);
            this.lvEmp.Name = "lvEmp";
            this.lvEmp.Size = new System.Drawing.Size(761, 447);
            this.lvEmp.SmallImageList = this.lvIcon;
            this.lvEmp.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmp.StateImageList = this.lvIcon;
            this.lvEmp.TabIndex = 0;
            this.lvEmp.UseCompatibleStateImageBehavior = false;
            this.lvEmp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "emp_id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account No";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee Name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Position";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Salary";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 130;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.ImageKey = "Division.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Division";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.ImageKey = "job_location.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 69);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Job Location";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.ImageKey = "department.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 69);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(777, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Department";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.lvgrade);
            this.tabPage5.ImageKey = "salary_grade.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 69);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(777, 505);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Grade";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.ImageKey = "designation.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 69);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(777, 505);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Designation";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage7.ImageKey = "Birthday_list.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 69);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(777, 505);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Birthday List";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Employee_Management.png");
            this.imageList1.Images.SetKeyName(1, "Division.png");
            this.imageList1.Images.SetKeyName(2, "job_location.png");
            this.imageList1.Images.SetKeyName(3, "department.png");
            this.imageList1.Images.SetKeyName(4, "salary_grade.png");
            this.imageList1.Images.SetKeyName(5, "designation.png");
            this.imageList1.Images.SetKeyName(6, "Birthday_list.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lastname:";
            // 
            // txtL
            // 
            this.txtL.Font = new System.Drawing.Font("Arial", 10F);
            this.txtL.Location = new System.Drawing.Point(278, 19);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(133, 23);
            this.txtL.TabIndex = 2;
            this.txtL.TextChanged += new System.EventHandler(this.txtL_TextChanged);
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Arial", 10F);
            this.txtF.Location = new System.Drawing.Point(487, 19);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(138, 23);
            this.txtF.TabIndex = 4;
            this.txtF.TextChanged += new System.EventHandler(this.txtF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname:";
            // 
            // txtAN
            // 
            this.txtAN.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAN.Location = new System.Drawing.Point(68, 20);
            this.txtAN.Name = "txtAN";
            this.txtAN.Size = new System.Drawing.Size(133, 23);
            this.txtAN.TabIndex = 6;
            this.txtAN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account No.";
            // 
            // lvgrade
            // 
            this.lvgrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvgrade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvgrade.FullRowSelect = true;
            this.lvgrade.GridLines = true;
            this.lvgrade.Location = new System.Drawing.Point(17, 19);
            this.lvgrade.Name = "lvgrade";
            this.lvgrade.Size = new System.Drawing.Size(741, 180);
            this.lvgrade.TabIndex = 0;
            this.lvgrade.UseCompatibleStateImageBehavior = false;
            this.lvgrade.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Grade";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Amount";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 130;
            // 
            // lvIcon
            // 
            this.lvIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lvIcon.ImageStream")));
            this.lvIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.lvIcon.Images.SetKeyName(0, "emp_icon.png");
            // 
            // MasterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 602);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tabMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterSettings";
            this.Text = "MasterSettings";
            this.tabMS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabControl tabMS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView lvEmp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvgrade;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ImageList lvIcon;
    }
}