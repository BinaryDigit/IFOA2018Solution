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
    public partial class frmSegreteria : Form
    {
        public frmSegreteria()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alunniToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmAlunni Alunni = new frmAlunni() { MdiParent = this };
            // Alunni.MdiParent = this;
            Alunni.Show();

        }

        private void frmSegreteria_Load(object sender, EventArgs e)
        {
        }

        private void esamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEsami frm_esami = new frmEsami() { MdiParent = this };
            frm_esami.Show();
        }

        private void esamiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEsamiSostenuti frm_EsamiSostenuti = new UI.frmEsamiSostenuti() { MdiParent = this };
            frm_EsamiSostenuti.Show();
        }
    }
}
