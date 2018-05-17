using Segreteria.Data.dsSegreteriaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Segreteria.Data.dsSegreteria;

namespace UI
{
    public partial class frmEsami : Form
    {
        ESAMITableAdapter dtaEsami = new ESAMITableAdapter();
        ESAMIDataTable dtEsami = new ESAMIDataTable();

        public frmEsami()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dtaEsami.Update(dtEsami);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(Row);
            }

            dtaEsami.Update(dtEsami);

        }

        private void frmEsami_Load(object sender, EventArgs e)
        {
            dtaEsami.Fill(dtEsami);
            dataGridView1.DataSource = dtEsami;
        }
    }
}
