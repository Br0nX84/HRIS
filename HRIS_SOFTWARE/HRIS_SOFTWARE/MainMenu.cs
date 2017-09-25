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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            sideMenu.Width = 54;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "HRIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            return;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sideMenu.Width = 54;
            btnMax.Visible = true;
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            sideMenu.Width = 250;
            btnMax.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            MasterSettings loadMS = new MasterSettings();
            loadMS.TopLevel = false;
            container.Controls.Add(loadMS);
            loadMS.Show();
        }
    }
}
