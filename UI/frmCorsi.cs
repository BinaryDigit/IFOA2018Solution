using Segreteria.Data;
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
    public partial class frmCorsi : Form
    {
        CORSILAUREATableAdapter dtaCorsi = new CORSILAUREATableAdapter();
        CORSILAUREADataTable dtCorsi = null;

        public frmCorsi()
        {
            InitializeComponent();
        }

        private void frmCorsi_Load(object sender, EventArgs e)
        {
            dtCorsi = dtaCorsi.GetData();
            dataGridView1.DataSource = dtCorsi;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dtaCorsi.Update(dtCorsi);
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

            dtaCorsi.Update(dtCorsi);
        }
    }
}
