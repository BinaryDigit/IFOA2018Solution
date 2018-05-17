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

namespace UI
{
    public partial class frmEsamiSostenuti : Form
    {
        DataTable dtEsamiSostenuti = null;
        ESAMISOSTENUTITableAdapter dtaEsamiSostenuti = new ESAMISOSTENUTITableAdapter();

        public frmEsamiSostenuti()
        {
            InitializeComponent();
        }

        private void Bind()
        {
            DataTable dtTuttiGliEsamiSostenuti = dtaEsamiSostenuti.GetDataByEsamiSostenuti();
            dataGridView1.DataSource = dtTuttiGliEsamiSostenuti;
        }

        private void frmEsamiSostenuti_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frmNuovoEsameSostenuto frm_NuovoEsameSostenuto = new UI.frmNuovoEsameSostenuto();
            frm_NuovoEsameSostenuto.ShowDialog(this);

            Bind();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            long Matricola = 0;

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                dataGridView1.DataSource = dtaEsamiSostenuti.GetDataByEsamiSostenuti();
            }
            else
            {
                if (long.TryParse(txtFilter.Text, out Matricola))
                {
                    dataGridView1.DataSource = dtaEsamiSostenuti.GetDataEsamisostenutiByMatricola(Matricola);
                }
            }


            dsSegreteriaTablesAdapters.ESAMISOSTENUTITableAdapter nn = new dsSegreteriaTablesAdapters.ESAMISOSTENUTITableAdapter();
            nn.GetDataByFilter("");
        }
    }
}
