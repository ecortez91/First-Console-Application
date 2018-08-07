using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Inscribir
    {

        public static void Main()
        {
            string NombreA;
            string DateA;
            string TelA;
            string CarA;
            int i = 0;
            int c = 0;
            string respuesta;
            string search;
            string[] name = new string[50];
            string[] date = new string[50];
            string[] phone = new string[50];
            string[] carnet = new string[50];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=====================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bienvenido al sistema de Inscripcion");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seleccione una de las siguientes opciones:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Ingrese 1 para agregar un nuevo alumno");
            Console.WriteLine("*Ingrese 2 para buscar/modificar alumno");
            Console.WriteLine("*Ingrese 3 para ver listado de alumnos inscritos");
            Console.WriteLine("*Para salir digite -1");
            string num = Console.ReadLine();
            Console.Clear();
            while (num != "-1")
            {

                switch (num)
                {
                    case "1":

                        do
                        {

                            NombreA = string.Empty;
                            DateA = string.Empty;
                            TelA = string.Empty;
                            respuesta = string.Empty;
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Title = "Inscripcion";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("======================================");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bienvenido al Registo de Inscripción");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("======================================");
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Favor ingresar los datos que le sean solicitados:");
                            Console.WriteLine(" ");

                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine("Ingrese el nombre del alumno");
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            NombreA = Console.ReadLine();
                            Console.WriteLine(" ");


                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine("Ingrese el Nº de carnet");
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            CarA = Console.ReadLine();
                            Console.WriteLine(" ");



                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine("Ingrese la fecha de nacimiento");
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            DateA = Console.ReadLine();
                            Console.WriteLine(" ");

                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine("Ingrese el numero de telefono domiciliar");
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            TelA = Console.ReadLine();
                            Console.WriteLine(" ");

                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("¿Son correctos estos datos?");
                            Console.WriteLine("Alumno: {0}", NombreA);
                            Console.WriteLine("Nº de Carnet: {0}", CarA);
                            Console.WriteLine("Fecha de Nacimiento: {0}", DateA);
                            Console.WriteLine("Tel: {0}", TelA);
                            Console.WriteLine("");
                            Console.WriteLine("(S/N)");
                            respuesta = Console.ReadLine();

                        } while (respuesta != "s");


                        name[i] = NombreA;
                        date[i] = DateA;
                        phone[i] = TelA;
                        carnet[i] = CarA;
                        i++;
                        c++;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Datos almacenados correctamente.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Escriba el Nº de carnet");
                        search = Console.ReadLine();
                        Console.Clear();
                        int j = 0;
                        bool find = false;
                        while (j < carnet.Length && find == false)
                        {
                            if (search == carnet[j])
                                find = true;

                            else

                                j++;

                        }
                        if (find == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("El numero de Carnet ingresado no existe");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Nº de carnet: {0}", carnet[j]);
                            Console.WriteLine("Nombre: {0}", name[j]);
                            Console.WriteLine("Fecha de nacimiento: {0}", date[j]);
                            Console.WriteLine("Telefono: {0}", phone[j]);
                            Console.WriteLine("");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("¿Desea realizar un cambio?");
                            Console.WriteLine("<S/N>");
                            string modans = Console.ReadLine();
                            while (modans == "s")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Ingrese el Nº del campo que desea modificar");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("1* Nº Carnet");
                                Console.WriteLine("2* Nombre");
                                Console.WriteLine("3* Fecha de Nacimiento");
                                Console.WriteLine("4* Telefono");
                                Console.WriteLine("-1 para salir");

                                string modopt = Console.ReadLine();

                                switch (modopt)
                                {

                                    case "1":
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Ingrese el nuevo Nº de Carnet");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        string newcarnet = Console.ReadLine();
                                        carnet[j] = newcarnet;
                                        break;
                                    case "2":
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Ingrese el nuevo Nombre");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        string newname = Console.ReadLine();
                                        name[j] = newname;
                                        break;

                                    case "3":
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Ingrese la fecha de nacimiento correcta");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        string newdate = Console.ReadLine();
                                        date[j] = newdate;
                                        break;

                                    case "4":
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Ingrese el nuevo Nº de Telefono");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        string newphone = Console.ReadLine();
                                        phone[j] = newphone;
                                        break;


                                }
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Datos almacenados correctamente.");
                                Console.ReadLine();

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("¿Desea realizar otra modificación?");
                                Console.WriteLine("<S/N>");
                                modans = Console.ReadLine();


                            }
                        }

                        break;

                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nº carnet // Nombre de alumno");
                        Console.ForegroundColor = ConsoleColor.White;
                        for (i = 0; i < c; i++)
                        {
                            Console.WriteLine("{0}          {1}", carnet[i], name[i]);
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        break;

                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=====================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bienvenido al sistema de Inscripcion");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=====================================");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una de las siguientes opciones:");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Ingrese 1 para agregar un nuevo alumno");
                Console.WriteLine("*Ingrese 2 para buscar alumno");
                Console.WriteLine("*Ingrese 3 para ver listado de alumnos inscritos");
                Console.WriteLine("*Para salir digite -1");
                num = Console.ReadLine();


            }




        }

    }

}