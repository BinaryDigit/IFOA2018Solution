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
    public partial class frmAlunni : Form
    {

        ALUNNITableAdapter dtaAlunni = new ALUNNITableAdapter();
        ALUNNIDataTable dtAlunni = new ALUNNIDataTable();

        public frmAlunni()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dtaAlunni.Update(dtAlunni);
        }

        private void frmAlunni_Load(object sender, EventArgs e)
        {
            dtaAlunni.Fill(dtAlunni);
            dataGridView1.DataSource = dtAlunni;          
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            foreach ( DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(Row);
            }

            dtaAlunni.Update(dtAlunni);
        }
    }
}
