using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSPro
{
    public partial class frmLogin : Form
    {
        models.clsUser objUser = new models.clsUser();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsGlobal.con.ConnectionString = "Data Source=orcl; User ID=system; Password=Admin@12345";
            try
            {
                clsGlobal.con.Open();
                //MessageBox.Show("Connection Susses");
            }
            catch
            {
                MessageBox.Show("Connection Issue");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            objUser.USERNAME = txtUsername.Text;
            objUser.PASSWORD = int.Parse(txtPassword.Text);

            if (objUser.Insert())
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert fail!");
            }

            //Hide();
            //frmMain frm = new frmMain();
            //frm.WindowState = FormWindowState.Maximized;
            //frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
