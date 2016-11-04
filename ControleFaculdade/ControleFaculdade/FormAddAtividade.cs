using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFaculdade
{
    public partial class FormAddAtividade : Form
    {
        public FormADD formAdd;

        public FormAddAtividade(FormADD FormAdd)
        {
            InitializeComponent();
            this.formAdd = FormAdd;
        }

        public FormAddAtividade()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formAdd.Show();
            FormAddAtividade formAddAtividade = new FormAddAtividade();
            formAddAtividade.Close();
        }

        private void FormAddAtividade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDataBaseDataSet.tblMateria' table. You can move, or remove it, as needed.
            this.tblMateriaTableAdapter.Fill(this.sampleDataBaseDataSet.tblMateria);

        }
    }
}
