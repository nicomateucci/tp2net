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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo): this()
        {
            InitializeComponent();
            this.Modo = modo;
        }
        public UsuarioDesktop(int id, ModoForm modo) : this()
        {
            InitializeComponent();
            this.Modo = modo;
            UsuarioLogic unUsuarioLogic = new UsuarioLogic();
            UsuarioActual = unUsuarioLogic.GetOne(id);
            this.MapearDeDatos();
            switch (Modo)
            { 
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }


        public Usuario UsuarioActual
        {
            set;get;
        }
        public override void MapearDeDatos()
        {
            this.txtId.Text = this.UsuarioActual.ID.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre.ToString();
            this.txtApellido.Text = this.UsuarioActual.Apellido.ToString();
            this.txtEmail.Text = this.UsuarioActual.Email.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario.ToString();
            this.txtClave.Text = this.UsuarioActual.Clave.ToString();
            this.txtConfClave.Text = this.UsuarioActual.Clave.ToString();
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
                else if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) this.UsuarioActual = new Usuario();
            else if ((Modo == ModoForm.Alta) || (Modo == ModoForm.Modificacion))
            {
                //UsuarioActual.ID =  this.textId.Text;
                //De donde saco el Id?
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            }
            if (Modo == ModoForm.Alta) UsuarioActual.State = BussinessEntity.States.New;
            else if (Modo == ModoForm.Baja) UsuarioActual.State = BussinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) UsuarioActual.State = BussinessEntity.States.Unmodified;
            else if (Modo == ModoForm.Modificacion) UsuarioActual.State = BussinessEntity.States.Modified;
        }
        public bool ValidarMail(string elMail)
        {
            return true;
        }

        //Falto usar el metodo Notificar de ApplicationForm
        //donde muestro cual es el error en el formulario.
        public override bool Validar()
        {
            bool tempReurn = false;
            if (this.txtId.Text.ToString() != null && this.txtApellido.Text.ToString() != null &&
               this.txtEmail.Text.ToString() != null && this.txtClave.Text.ToString() != null &&
               this.txtClave.Text.ToString() != null && this.txtConfClave.Text.ToString() != null &&
               this.txtUsuario.Text.ToString() != null)
            {
                if (txtClave.Text.ToString() == txtConfClave.Text.ToString())
                {
                    if (txtClave.Text.Length >= 8 && txtConfClave.Text.Length >= 8)
                    {
                        if (this.ValidarMail(this.txtEmail.Text.ToString()))
                        {
                            tempReurn = true;
                        }
                    }
                }
            } 

                return tempReurn;  
        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            UsuarioLogic unUserLogic = new UsuarioLogic();
            unUserLogic.Save(UsuarioActual);
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
