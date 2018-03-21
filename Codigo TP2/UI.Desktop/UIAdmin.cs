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

namespace UI.Desktop
{
    public partial class UIAdmin : ApplicationForm
    {
        public UIAdmin(Usuario elUsuario)
        {
            InitializeComponent();
            this.lblBienbenidaUsuario.Text = elUsuario.Nombre + elUsuario.Apellido;
        }
    }
}
