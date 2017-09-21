using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness.Logic;

namespace UI.Desktop
{
    public partial class Usuarios : ApplicationForm
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            UsuarioLogic userLogic = new UsuarioLogic();
            this.dataGridViewUsuarios.DataSource = userLogic.GetAll();
        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
