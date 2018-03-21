using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness.Entities;
using Bussiness.Logic;

namespace UI.Desktop
{
    public partial class Login : ApplicationForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (lblUsuario.Text != null || txtPwd.Text == null)
            {
                Bussiness.Logic.UsuarioLogic userLogic = new Bussiness.Logic.UsuarioLogic();
                int id = userLogic.Login(txtUsuario.Text, txtPwd.Text);
                if (id != 0)
                {
                    Usuario user = userLogic.GetOne(id);
                    int tipoUsuario = user.MiTipo();
                    //En lugar de hacer 3 if, podria definir los botonoes segun el tipo de usuario, pero por ahora lo dejo asi.
                    if (tipoUsuario == 0)
                    {
                        UIAdmin frmAdmin = new UIAdmin(user);
                        frmAdmin.Show();
                    }
                    else if ( tipoUsuario == 1)
                    {
                        UIDocente frmDocente = new UIDocente(user);
                        frmDocente.Show();
                    }
                    else
                    {
                        UIAlumno frmAlumno = new UIAlumno(user);
                        frmAlumno.Show();
                    }
                    this.Close();
                }
                else { lblError.Visible = true; };
            }
            else
            {
                lblUsuario.Text = "Usuario o contraseña vacios";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Luser_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_DragEnter(object sender, DragEventArgs e)
        {
            this.btnIngresar_Click(sender,e);
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            this.btnIngresar_Click(sender, e);
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnIngresar_Click(sender, e);
            }
        }

        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
