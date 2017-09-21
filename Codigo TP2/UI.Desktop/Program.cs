﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UIAlumno uialum = new UIAlumno();
            /*Ultimo problema: No podia modificar controles de UIAlumno, porque estaban definidos en ApplicationForm (Su padre),
             */
            Application.Run(new UIAlumno());
        }
    }
}