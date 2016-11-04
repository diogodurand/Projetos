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
    public partial class FormAddMateria : Form
    {
        public FormADD formAdd;

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

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.formAdd.Show();
            FormAddMateria formAddMateria = new FormAddMateria();
            formAddMateria.Close();
        }
    }
}
