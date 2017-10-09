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
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tp2_netDataSet.usuarios);
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesk = new UsuarioDesktop();
            usuarioDesk.ShowDialog();

        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
