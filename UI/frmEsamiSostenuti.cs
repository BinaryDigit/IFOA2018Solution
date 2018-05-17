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
        dsSegreteria.ESAMIDataTable dtEsamiSostenuti = null;
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
    }
}
