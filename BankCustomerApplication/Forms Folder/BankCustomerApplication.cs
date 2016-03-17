using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCustomerApplication
{
    public partial class BankCustomerApplication : Form
    {
    
        public static ToolStripButton ToolStripButtonDeleteustomer;
        public static ToolStripButton ToolStripButtonUpdateCustomer;
        public BankCustomerApplication()
        {
            InitializeComponent();
            ToolStripButtonDeleteustomer = this.toolStripButtonDeleteCustomer;
            ToolStripButtonUpdateCustomer = this.toolStripButtonUpdateCustomer;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            InsertNewCustomer form = new InsertNewCustomer(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            SearchForCustomersForm form = new SearchForCustomersForm(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

      

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BankCustomerApplication_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.BackColor = Color.Gold;
            toolStripStatusLabel1.Text = "Welcome to BankCustomerApplication";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteCustomer form = new FormDeleteCustomer(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferingMoneyForm form = new TransferingMoneyForm(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForCustomersForm form = new SearchForCustomersForm(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string ID = SearchForCustomersForm.TargetCustomerID;
            FormDeleteCustomer form = new FormDeleteCustomer(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerDataForUpdating form = new FormCustomerDataForUpdating(toolStripStatusLabel1);
            form.MdiParent = this;
            form.Show();

        }
    }
}
