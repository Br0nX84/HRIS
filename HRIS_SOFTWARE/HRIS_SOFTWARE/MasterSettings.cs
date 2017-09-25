using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS_SOFTWARE
{
    public partial class MasterSettings : Form
    {
        public MasterSettings()
        {
            InitializeComponent();
            Connection.InitializeDB();
            LoadAll();
            loadGrade();
        }

        public void loadGrade()
        {
            List<Grade> grade = Grade.GetGrade();

            lvgrade.Items.Clear();

            foreach (Grade g in grade)
            {

                ListViewItem item = new ListViewItem(new String[] { g.Id.ToString(), g.grade.ToString(),g.amount.ToString() });
                item.Tag = g;

                lvgrade.Items.Add(item);

            }
        }

       public void LoadAll()
        {
            List<EmpManagement> emp = EmpManagement.GetEmployee();

            lvEmp.Items.Clear();

            foreach(EmpManagement e in emp)
            {

                ListViewItem item = new ListViewItem(new String[] { e.Id.ToString(), e.AccountNo.ToString(), e.Empname.ToString(), e.Position.ToString(), e.Salary.ToString() });
                item.Tag = e;

                lvEmp.Items.Add(item);

            }
        }


        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSearch()
        {
            List<EmpManagement> emp = EmpManagement.GetSearch(txtAN.Text,txtL.Text,txtF.Text);

            lvEmp.Items.Clear();

            foreach(EmpManagement e in emp)
            {
                ListViewItem item = new ListViewItem(new String[] { e.Id.ToString(), e.AccountNo.ToString(), e.Empname.ToString(), e.Position.ToString(), e.Salary.ToString() });
                item.Tag = e;

                lvEmp.Items.Add(item);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            LoadSearch();
        }
    }
}
