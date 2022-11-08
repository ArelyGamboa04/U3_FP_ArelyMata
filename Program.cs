using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArelyMata_Tarea_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string nombreUsuario;
            byte edadUsuario;
            string apellidoUsuario, direccionUsuario, celularUsuario, perfilUsuario, usuarioAcceso, contraseñaUsuario, confirmContraseña, codigoAcceso;

            //Personalizar de la consola
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetWindowSize(80, 30);
            Console.Clear();

            //Pedir nombre del usuario
            Console.WriteLine("Ingresa tu nombre:");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad:");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //Aplicacion de la selectiva "if"
            if (edadUsuario > 18)
            {
                //informacion del usuario
                Console.WriteLine("Ingresa tu apellido:");
                apellidoUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu direccion:");
                direccionUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu número celular:");
                celularUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa el nombre de tu perfil:");
                perfilUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu nombre de usuario:");
                usuarioAcceso = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña:");
                contraseñaUsuario = Console.ReadLine();
                Console.WriteLine("Confirma tu contraseña:");
                confirmContraseña = Console.ReadLine();


                //aplicacion del if
                if (contraseñaUsuario == confirmContraseña)
                {
                    Random aleatorio = new Random();
                    aleatorio.Next(1000, 9999);

                    codigoAcceso = aleatorio.ToString();

                    //Registro de usuario
                    Console.WriteLine("\n Informacion del usuario:");
                    Console.WriteLine("Nombre Apellido: {1}, Edad: {2}, Direccion: {3}, Numero Celular: {4}", nombreUsuario, apellidoUsuario, edadUsuario, direccionUsuario, celularUsuario);
                    Console.WriteLine("Nombre de perfil: {0}, Usuario: {1}", perfilUsuario, usuarioAcceso);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Codigo de acceso: {0}", codigoAcceso);


                    //validar
                    if (contraseñaUsuario == confirmContraseña)
                    {
                        //ramdom
                        Console.WriteLine("Codigo de acesso 31241");
                    }

                    else
                    {
                        Console.WriteLine("tu contrasena no fue validada");
                        Thread.Sleep(300);
                        return;
                    }

                    Console.ReadKey();

                }


            }
        }
    }
}

            
        
    


        
    

