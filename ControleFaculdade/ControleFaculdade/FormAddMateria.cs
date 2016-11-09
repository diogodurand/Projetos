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
    public partial class FormAddMateria : Form
    {
        public FormADD formAdd;
        BD BD = new BD();
        SqlDataReader leitor;
        public string nomeMateria;


        public FormAddMateria(FormADD FormAdd)
        {
            InitializeComponent();
            this.formAdd = FormAdd;
        }
        
        public FormAddMateria()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "Processando...";
                
            int ultimoId;
            nomeMateria = txtNomeDaMateria.Text.ToString();
            string sql;
            leitor = BD.Select("Select MAX(ID) as id FROM tblMateria");
            leitor.Read();

            if (leitor["ID"].ToString().Equals(""))
            {
                ultimoId = 0;

            }else { 
                ultimoId = Convert.ToInt32(leitor["ID"].ToString());
            }

            sql = "insert into tblMateria"
                  + " (ID, NOME_MATERIA)"
                  + " values ("+( ultimoId +1) +", '"+ nomeMateria + "')";
            BD.Insert(sql);

            txtResultado.Text = "Insert Realizado com Sucesso!";

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.formAdd.Show();
            FormAddMateria formAddMateria = new FormAddMateria();
            formAddMateria.Close();
        }
    }
}
