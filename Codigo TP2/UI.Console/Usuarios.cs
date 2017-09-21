using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Entities;
using Bussiness.Logic;

namespace UI.Console
{
    public class Usuarios
    {
        public Bussiness.Logic.UsuarioLogic UsuarioNegocio
        {
            set; get;
        }

        public Usuarios()
        {
            UsuarioNegocio = new Bussiness.Logic.UsuarioLogic();
        }
        public void Menu()
        {
            int opc = 0;

            do
            {
                System.Console.Clear();
                System.Console.WriteLine("Listado de opciones");
                System.Console.WriteLine("1 - Listado general");
                System.Console.WriteLine("2 - Consultar");
                System.Console.WriteLine("3 - Agregar");
                System.Console.WriteLine("4 - Modificar");
                System.Console.WriteLine("5 - Eliminar");
                System.Console.WriteLine("6 - Salir");
                opc = int.Parse(System.Console.ReadLine());
            switch (opc)
            {
                case 1:
                    this.ListadoGeneral();
                    break;
                case 2:
                    this.Consultar();
                    break;
                case 3:
                    this.Agregar();
                    break;
                case 4:
                    this.Modificar();
                    break;
                case 5:
                    this.Eliminar();
                    break;
            }
            } while (opc != 6);
        }
        public void ListadoGeneral()
        {
            System.Console.Clear();
            foreach(Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);            
            }
            System.Console.ReadKey();
        }
        public void Consultar()
        {
            try
            {
                System.Console.Clear();
                System.Console.WriteLine("Ingrese el ID de usuario ");
                int Id = int.Parse(System.Console.ReadLine());
                //this.MostrarDatos(UsuarioNegocio.GetAll());
            }
            catch (FormatException fe)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Presione una tecla para continuar");
                System.Console.ReadKey();
            }
        }
        public void Agregar()
        {
            Usuario unUsuario = new Usuario();

            System.Console.WriteLine("Ingrese nuevo nombre");
            unUsuario.Nombre = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese nuevo apellido");
            unUsuario.Apellido = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese nuevo nombre de usuario");
            unUsuario.NombreUsuario = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese nuevo nombre clave");
            unUsuario.Clave = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese nuevo nombre email");
            unUsuario.Email = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese habilitacion de usuario | 1 - Si / Otro - No |");
            unUsuario.Habilitado = (System.Console.ReadLine() == "1");
            unUsuario.State = BussinessEntity.States.New;
            UsuarioNegocio.Save(unUsuario);
            System.Console.WriteLine();
            System.Console.Write("El Id que se le asigno por defecto fue: ", unUsuario.ID);
            System.Console.ReadKey();

        }
        public void Modificar()
        {

            try
            {
                System.Console.Clear();
                System.Console.WriteLine("Ingrese el ID del usuario a modificar");
                int Id = int.Parse(System.Console.ReadLine());
                Usuario elUsuario = UsuarioNegocio.GetOne(Id);
                System.Console.WriteLine("Ingrese nuevo nombre");
                elUsuario.Nombre = System.Console.ReadLine();
                System.Console.WriteLine("Ingrese nuevo apellido");
                elUsuario.Apellido = System.Console.ReadLine();
                System.Console.WriteLine("Ingrese nuevo nombre de usuario");
                elUsuario.NombreUsuario = System.Console.ReadLine();
                System.Console.WriteLine("Ingrese nuevo nombre clave");
                elUsuario.Clave = System.Console.ReadLine();
                System.Console.WriteLine("Ingrese nuevo nombre email");
                elUsuario.Email = System.Console.ReadLine();
                System.Console.WriteLine("Ingrese habilitacion de usuario | 1 - Si / Otro - No |");
                //--------------------------------------------------------------------
                elUsuario.Habilitado = (System.Console.ReadLine() == "1");
                //-------------------------------------------------------------------------------------
                elUsuario.State = BussinessEntity.States.Modified;
                UsuarioNegocio.Save(elUsuario);
            }
            catch (FormatException fe)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Presione una tecla para continuar");
                System.Console.ReadKey();
            }
        }
        public void Eliminar()
        {
            try
            {
                System.Console.Clear();
                System.Console.WriteLine("Ingrese el ID del usuario a eliminar");
                int Id = int.Parse(System.Console.ReadLine());
                UsuarioNegocio.Delete(Id);
            }
            catch (FormatException fe)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Presione una tecla para continuar");
                System.Console.ReadKey();
            }

        }
        public void MostrarDatos(Usuario user)
        {
            System.Console.WriteLine("Usuario: ", user.ID.ToString());
            System.Console.WriteLine("\t\tNombre: ", user.Nombre);
            System.Console.WriteLine("\t\tApellido: ", user.Apellido);
            System.Console.WriteLine("\t\tNombre de usuario: ", user.NombreUsuario);
            System.Console.WriteLine("\t\tClave: ", user.Clave);
            System.Console.WriteLine("\t\tEmail: ", user.Email);
            System.Console.WriteLine("\t\tHabilitado: ", user.Habilitado.ToString());
            System.Console.WriteLine();
        }
    }
}
