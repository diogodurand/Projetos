using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        BD BD = new BD();
        public string nomeAtividade;
        public string descAtividade;
        public string dataEntrega;
        public int idMateria;
        string sql;
        StringBuilder errorMessages = new StringBuilder();

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
            nomeAtividade = txtNomeDaAtividade.Text.ToString();
            descAtividade = boxDescAtividade.Text.ToString();
            dataEntrega = dtDataEntrega.Text.ToString();
            idMateria = int.Parse(comboMateria.SelectedValue.ToString());

            sql = "INSERT INTO tblAtividade"
                + " (ID_MATERIA, NOME_ATIVIDADE, DESC_ATIVIDADE, DATA_ENTREGA)"
                + " VALUES ("+ idMateria + ",'" + nomeAtividade + "','" + descAtividade + "','" + dataEntrega +"')";

            BD.Insert(sql);            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formAdd.Show();
            FormAddAtividade formAddAtividade = new FormAddAtividade();
            formAddAtividade.Close();
        }

        private void FormAddAtividade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBControleFaculdadeDataSet.tblMateria' table. You can move, or remove it, as needed.
            this.tblMateriaTableAdapter1.Fill(this.dBControleFaculdadeDataSet.tblMateria);
            // TODO: This line of code loads data into the 'sampleDataBaseDataSet.tblMateria' table. You can move, or remove it, as needed.


        }
    }
}
