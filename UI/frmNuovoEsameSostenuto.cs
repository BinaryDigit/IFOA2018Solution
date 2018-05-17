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
    public partial class frmNuovoEsameSostenuto : Form
    {
        ALUNNITableAdapter dtaAlunni = new ALUNNITableAdapter();
        ESAMITableAdapter dtaEsami = new ESAMITableAdapter();

        ESAMISOSTENUTITableAdapter dtaEsamiSostenuti = new ESAMISOSTENUTITableAdapter();

        public frmNuovoEsameSostenuto()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ALUNNIDataTable dtAlunni = null;
        private void frmNuovoEsameSostenuto_Load(object sender, EventArgs e)
        {
            dtAlunni = dtaAlunni.GetData();
            comboBox1.DataSource = dtAlunni;
            comboBox1.ValueMember = "Matricola";
            comboBox1.DisplayMember = "Matricola";

            comboBox2.DataSource = dtaEsami.GetData();
            comboBox2.ValueMember = "idEsame";
            comboBox2.DisplayMember = "NomeEsame";            
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Voto = -1;
                bool Converted = int.TryParse(textBox1.Text, out Voto);
                if (!Converted)
                {
                    MessageBox.Show(this, "Errore nella conversione"
                            , "Voto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }


                ESAMISOSTENUTIDataTable dtEsamiSostenuti = new ESAMISOSTENUTIDataTable();
                dtEsamiSostenuti.Rows.Add(comboBox1.SelectedValue, comboBox2.SelectedValue, Voto, dateTimePicker1.Value);
                dtaEsamiSostenuti.Update(dtEsamiSostenuti);

                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, "Non e' stato possibile salvare i dati, contattare il supporto"
                        , "Errore nel salvataggio dei dati", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(exc);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int Voto = -1;
            bool Converted = int.TryParse(textBox1.Text, out Voto);
            if (!Converted)
            {
                MessageBox.Show(this, "Errore nella conversione"
                        , "Voto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ALUNNIRow arAlunno = dtAlunni[comboBox1.SelectedIndex];
            lblNominativo.Text = arAlunno.Nome + " " + arAlunno.Cognome;
        }
    }
}
