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
    public partial class FormADD : Form
    {
        private Form1 home;


        public FormADD(Form1 Home)
        {
            InitializeComponent();
            this.home = Home;
        }

        public FormADD() {
            InitializeComponent();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            home.Show();
            FormADD formAdd = new FormADD();
            formAdd.Close();

        }

        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            FormAddMateria formAddMateria = new FormAddMateria(this);
            formAddMateria.Show();
            this.Visible = false;
        }

        private void btnAddAtividade_Click(object sender, EventArgs e)
        {
            FormAddAtividade formAddAtividade = new FormAddAtividade(this);
            formAddAtividade.Show();
            this.Visible = false;
        }

        private void FormADD_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Close();
        }
    }
}
