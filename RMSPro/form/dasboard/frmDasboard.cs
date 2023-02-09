using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSPro.form
{
    public partial class frmDasboard : Form
    {
        public frmDasboard()
        {
            InitializeComponent();
        }

        private void frmDasboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
