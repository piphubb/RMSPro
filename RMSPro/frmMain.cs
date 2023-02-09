using RMSPro.form.category;
using RMSPro.form.customer;
using RMSPro.form.employee;
using RMSPro.form.products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSPro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoryShow_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //clsGlobal.con.ConnectionString = "Data Source=orcl; User ID=system; Password=Admin@12345";
            //try
            //{
            //    clsGlobal.con.Open();
            //    //MessageBox.Show("Connection Susses");
            //}
            //catch
            //{
            //    MessageBox.Show("Connection Issue");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
