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
    }
}
