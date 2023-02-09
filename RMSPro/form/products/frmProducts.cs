using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSPro.form.products
{
    public partial class frmProducts : Form
    {
        models.clsProducts objProducts = new models.clsProducts();
        public frmProducts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = objProducts.GetDate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            txtProductId.Text = dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString();
            txtProductNameKh.Text = dgvProducts.CurrentRow.Cells["ProductNameKh"].Value.ToString();
            txtProductNameEn.Text = dgvProducts.CurrentRow.Cells["ProductNameEn"].Value.ToString();
            txtBarcode.Text = dgvProducts.CurrentRow.Cells["Barcode"].Value.ToString();
            txtPrice.Text = dgvProducts.CurrentRow.Cells["Price"].Value.ToString();
            txtCost.Text = dgvProducts.CurrentRow.Cells["Cost"].Value.ToString();
            txtCategoryId.Text = dgvProducts.CurrentRow.Cells["CategoryId"].Value.ToString();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objProducts.PRODUCTNAMEKH = txtProductNameKh.Text;
            objProducts.PRODUCTNAMEEN = txtProductNameEn.Text;
            objProducts.BARCODE = int.Parse(txtBarcode.Text);
            objProducts.PRICE = int.Parse(txtPrice.Text);
            objProducts.COST = int.Parse(txtCost.Text);
            objProducts.CATEGORYID = int.Parse(txtCategoryId.Text);

            if (objProducts.Insert())
            {
                dgvProducts.DataSource = objProducts.GetDate();
                MessageBox.Show("Insert Susses");
            }
            else
            {
                MessageBox.Show("Insert fail!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objProducts.PRODUCTID = int.Parse(txtProductId.Text);
            objProducts.PRODUCTNAMEKH = txtProductNameKh.Text;
            objProducts.PRODUCTNAMEEN = txtProductNameEn.Text;
            objProducts.BARCODE = int.Parse(txtBarcode.Text);
            objProducts.PRICE = int.Parse(txtPrice.Text);
            objProducts.COST = int.Parse(txtCost.Text);
            objProducts.CATEGORYID = int.Parse(txtCategoryId.Text);

            if (objProducts.Update())
            {
                dgvProducts.DataSource = objProducts.GetDate();
                MessageBox.Show("Insert Susses");
            }
            else
            {
                MessageBox.Show("Insert fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                objProducts.PRODUCTID = int.Parse(txtProductId.Text);

                if (objProducts.Delete())
                {

                    dgvProducts.DataSource = objProducts.GetDate();
                    MessageBox.Show("Delete Susses");
                }
                else
                {
                    MessageBox.Show("Delete fail!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = objProducts.GetDate(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
