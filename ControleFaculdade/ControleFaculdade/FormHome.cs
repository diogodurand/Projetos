using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static ControleFaculdade.DBControleFaculdadeDataSet;

namespace ControleFaculdade
{
    public partial class FormHome : Form
    {
        BD BD = new BD();
        public string nomeAtividade;
        public string descAtividade;
        public string dataEntrega;
        public int idMateria;
        DataTable atividades = new DataTable();
        FormAddAtividade formAtividade = new FormAddAtividade();
        FormAddMateria formMateria = new FormAddMateria();




        public FormHome()
        {
            InitializeComponent();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMateria.ShowDialog() == DialogResult.OK) {

                formMateria.Close();
            };

        }

        private void atividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new FormAddAtividade());
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBControleFaculdadeDataSet.tblMateria' table. You can move, or remove it, as needed.
            this.tblMateriaTableAdapter.Fill(this.dBControleFaculdadeDataSet.tblMateria);
            

            try
            {
                tblAtividadeTableAdapter.FillById(dBControleFaculdadeDataSet.tblAtividade, (int)this.cmbMateria.SelectedValue);
            }
            catch { }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMateria_Click(object sender, EventArgs e)
        {
            
            

        }


        private void cmbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tblAtividadeTableAdapter.FillById(dBControleFaculdadeDataSet.tblAtividade, (int)this.cmbMateria.SelectedValue);
            }
            catch { }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblMateriaTableAdapter.FillBy(this.dBControleFaculdadeDataSet.tblMateria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
