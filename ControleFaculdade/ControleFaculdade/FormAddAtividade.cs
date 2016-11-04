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
        BDconnection conexao = new BDconnection();
        public string nomeAtividade;
        public string descAtividade;
        public string dataEntrega;
        public int idMateria;
        string sql;
        SqlCommand command;

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
            conexao.OpenConnection();
            nomeAtividade = txtNomeDaAtividade.Text.ToString();
            descAtividade = boxDescAtividade.Text.ToString();
            dataEntrega = dtDataEntrega.Text.ToString();
            idMateria = int.Parse(comboMateria.SelectedValue.ToString());

            sql = "INSERT INTO SampleDataBaseDataSet VALUES " +
                  "("+ idMateria + ",'" + nomeAtividade + "','" + descAtividade + "','" +dataEntrega+"')";

            command = new SqlCommand(sql, conexao.bdConn);

            try
            {

            }
            catch
            {

            }
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
