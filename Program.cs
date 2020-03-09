using System;
using System.Collections.Generic;
namespace Itla_Trans

{
    class Program
    {
        private struct clientes
        {
            public string nombreC { get; set; }
            public string rutasS { get; set; }
            public double Costo { get; set; }

        }

        private struct Autobus
        {
            public double matricula { get; set; }
            public string modelo { get; set; }
            public string marca { get; set; }
            public int capacidad { get; set; }

        }
        private struct choferes
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public double telefono { get; set; }
            public int asignacion { get; set; }
        }
        private struct AsigChofer
        {
            public List<string> chofer { get; set; }
            public List<string> autobus { get; set; }

            public AsigChofer(List<string> _chofer, List<string> _autobus)
            {
                chofer = _chofer;
                autobus = _autobus;
            }



        }
        private struct AsigAutobus
        {
            public string Ruta { get; set; }
            public List<string> autobus { get; set; }
            public AsigAutobus(string ruta, List<string> Autobus)
            {

                Ruta = ruta;
                autobus = Autobus;
            }



        }
        private struct Ruta
        {
            public string ciudadOrigen { get; set; }
            public string ciudadDestino { get; set; }
            public int costoRuta { get; set; }
        }
        private static List<clientes> LCliente = new List<clientes>();
        private static List<string> Asignacion = new List<string>();
        private static List<string> autobusesAsignados = new List<string>();
        private static List<string> Tickets = new List<string>();
        private static List<Autobus> LAutobus = new List<Autobus>();

        private static List<choferes> LChoferes = new List<choferes>();

        private static List<Ruta> LRuta = new List<Ruta>();
        private static List<AsigChofer> LAsignacion = new List<AsigChofer>();
        private static List<AsigAutobus> LAsignacionAutobus = new List<AsigAutobus>();
        static void Main(string[] args)

        {

            while (true)
            {
                Console.Clear();
                Menu();
            }
        }


        private static void Menu()
        {


            Console.WriteLine("----------ItlaTrans----------\nSeleccione una opcion:\n1.-Autobus\n2.-Ruta\n3.-Chofer\n4.-Ticket\n5.-Reservacines\n6.-Salir");


            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("----------AUTOBUS----------\n1.-Registrar autobus\n2.-Modificar autobus\n3.-Mostrar autobus/es\n4.-Eliminar autobus");
                    int rAutobus = 0;
                    rAutobus = Convert.ToInt32(Console.ReadLine());

                    switch (rAutobus)
                    {
                        case 1:
                            RegistrarAutobus();
                            break;
                        case 2:
                            ModificarAutobus();
                            break;
                        case 3:
                            MostrarA();
                            Console.ReadKey();
                            break;
                        case 4:
                            EliminarAutobus();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----------RUTAS----------\n1.-Registrar ruta\n2.-Asignar autobuses\n3.-Mostrar ruta\n4.-Modificar ruta/s\n5.-Eliminar ruta");
                    int rRutas = 0;
                    rRutas = Convert.ToInt32(Console.ReadLine());
                    {
                        switch (rRutas)
                        {
                            case 1:
                                RegistrarRutas();
                                break;
                            case 2:
                                AsignarAutobus2();
                                break;
                            case 3:
                                MostrarR();
                                Console.ReadKey();
                                break;
                            case 4:
                                ModificarRuta();
                                Console.ReadKey();
                                break;
                            case 5:
                                EliminarRuta();
                                break;
                        }
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("----------CHOFER----------\n1.-Registrar chofer\n2.-Asignar autobus\n3.-Mostrar chofer/es\n4.-Modificar chofer/s\n5.-Eliminar chofer");
                    int rChofer = 0;
                    rChofer = Convert.ToInt32(Console.ReadLine());
                    {
                        switch (rChofer)
                        {
                            case 1:
                                RegistrarChoferes();
                                break;
                            case 2:
                                asignarAutobuses();

                                break;
                            case 3:
                                MostrarC();
                                Console.ReadKey();
                                break;
                            case 4:
                                ModificarChofer();
                                Console.ReadKey();
                                break;
                            case 5:
                                EliminarChofer();
                                break;
                        }
                        break;
                    }
                case 4:
                    Console.Clear();
                    Console.WriteLine("----------TICKET----------\n1.-Reservar Tickets");
                    Ticket();
                   
                        
                        break;
                case 5:
                    Reservaciones();
                   
                    break;
                case 6:
                   
                    Console.WriteLine("Hablamos nunca, porque si te digo que hablamos el martes, tieeeenen esperanza");
                    Console.ReadKey();
                 
                    break;
            }



        }

        private static string GetElement<T>(List<T> listado, int index)
        {
            return listado[index].ToString();
        }


        private static void RegistrarAutobus()
        {
            Autobus item = new Autobus();


            Console.WriteLine("Introduzca la matricula del autobus:");
            double Matricula = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el modelo del autobus:");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Introduzca la marca del autobus:");
            string Marca = Console.ReadLine();
            Console.WriteLine("Introduzca la capacidad del autobus:");
            int Capacidad = Convert.ToInt32(Console.ReadLine());
            item.matricula = Matricula;
            item.modelo = Modelo;
            item.marca = Marca;
            item.capacidad = Capacidad;
            Add(LAutobus, item);


        }
        private static void RegistrarRutas()
        {
            Ruta item = new Ruta();


            Console.WriteLine("Introduzca la ciudad de origen:");
            string CiudadOrigen = Console.ReadLine();
            Console.WriteLine("Introduzca la ciudad de destino:");
            string CiudadDestino = Console.ReadLine();
            Console.WriteLine("Introduzca el costo de la ruta:");
            int CostoRuta = Convert.ToInt32(Console.ReadLine());

            item.ciudadOrigen = CiudadOrigen;
            item.ciudadDestino = CiudadDestino;
            item.costoRuta = CostoRuta;

            Add(LRuta, item);


        }
        private static void RegistrarChoferes()
        {
            int contador = 1;
            choferes item = new choferes();


            Console.WriteLine("Introduzca el nombre del chofer:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido del chofer:");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Introduzca el numero de telefono del chofer:");
            double Telefono = Convert.ToDouble(Console.ReadLine());

            item.nombre = Nombre;
            item.apellido = Apellido;
            item.telefono = Telefono;


            Add(LChoferes, item);


        }
        private static void RegistrarClientes()
        {
            int contador = 1;
            clientes item = new clientes();


            Console.WriteLine("Introduzca el nombre del cliente:");
            string Nombre = Console.ReadLine();
          

            item.nombreC = Nombre;
      


            Add(LCliente, item);


        }

        private static void AsignarAutobus2()
        {
            try {
                if (LAsignacion.Count > 0)
                {
                    Console.WriteLine("Listado de autobuses disponibles");

                    autobusesAsignados = new List<string>();
                    List(LAsignacionAutobus);

                    Console.Write("Seleccione el autobus que desea agregarle la ruta:");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Seleccione la ruta:");
                    string ruta = GetElement(LRuta, (index - 1));
                    MostrarR();

                    if (autobusesAsignados.Count <= 0)
                    {
                        Console.WriteLine("Intruduzca una opcion valida");
                        Console.ReadKey();

                    }
                    else
                    {
                        AsigAutobus asigAutobus = new AsigAutobus(ruta, autobusesAsignados);
                        Add(LAsignacionAutobus, asigAutobus);
                    }
                }
                else
                {
                    Console.WriteLine("No existen autobuses disponibles en el sistema");
                    Console.ReadKey();


                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error " + ex.Message);
                Console.ReadKey();

            }
        }

        private static void Add<T>(List<T> listado, T item)

        {
            listado.Add(item);

        }

        public static void MostrarA()
        {
            int contador = 1;
            foreach (Autobus item in LAutobus)
            {
                Console.WriteLine(contador + "-" + "Matricula del autobus : " + item.matricula + "\nModelo del autobus : " + item.modelo + "\nMarca del autobus : " + item.marca + "\nCapacidad del autobus : " + item.capacidad);
                contador++;
            }
        }
        public static void MostrarR()
        {
            int contador = 1;
            foreach (Ruta item in LRuta)
            {
                Console.WriteLine(contador + "-" + "Ruta de origen : " + item.ciudadOrigen + "\nRuta de destino : " + item.ciudadDestino + "\nCosto de la ruta : " + item.costoRuta);
                contador++;
            }
        }


        public static void MostrarC()
        {
            int contador = 1;
            foreach (choferes item in LChoferes)
            {
                Console.WriteLine(contador + "-" + "Nombre del chofer : " + item.nombre + "\nApellido del Chofer : " + item.apellido + "\nTelefono del chofer : " + item.telefono + "\nAutobus/es asignados : " + item.asignacion);
                contador++;
            }
        }
        public static void MostrarCL()
        {
            int contador = 1;
            foreach (clientes item in LCliente)
            {
                Console.WriteLine(contador + "-" + "Nombre del cliente : " + item.nombreC + "Ruta selecionada: " + item.rutasS + "Total a pagar : " + item.Costo);
                contador++;
            }
        }

        private static void List<T>(List<T> listado)
        {
            int contador = 1;

            foreach (T item in listado)
            {
                Console.WriteLine(contador + "-" + item);
                contador++;


            }

        }


        private static void Edit<T>(List<T> listado, int index, T value)

        {
            listado[index] = value;
        }
        private static void Delete<T>(List<T> listado, int index)

        {
            listado.RemoveAt(index);
        }


        private static void ModificarAutobus()
        {
            Autobus item = new Autobus();
            Console.WriteLine("Seleccione el autobus que desea editar:");
            MostrarA();

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la nueva matricula del autobus:");
            double Matricula = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el nuevo modelo del autobus:");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Introduzca la nueva marca del autobus:");
            string Marca = Console.ReadLine();
            Console.WriteLine("Introduzca la nueva capacidad del autobus:");
            int Capacidad = Convert.ToInt32(Console.ReadLine());
            item.matricula = Matricula;
            item.modelo = Modelo;
            item.marca = Marca;
            item.capacidad = Capacidad;
            LAutobus[index - 1] = item;

        }

        private static void ModificarRuta()
        {
            Ruta item = new Ruta();
            Console.WriteLine("Seleccione la ruta que desea editar:");
            MostrarR();

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la nueva ciudad de origen:");
            string CiudadOrigen = Console.ReadLine();
            Console.WriteLine("Introduzca la nueva ciudad de destino:");
            string CiudadDestino = Console.ReadLine();
            Console.WriteLine("Introduzca el nuevo costo de la ruta:");
            int CostoRuta = Convert.ToInt32(Console.ReadLine());

            item.ciudadOrigen = CiudadOrigen;
            item.ciudadDestino = CiudadDestino;
            item.costoRuta = CostoRuta;

            LRuta[index - 1] = item;

        }
        private static void ModificarChofer()
        {
            choferes item = new choferes();
            Console.WriteLine("Seleccione el chofer que desea modificar:");
            MostrarC();

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nuevo nombre del chofer:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el nuevo apellido del chofer:");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Introduzca el nuevo telefono del chofer:");
            double Telefono = Convert.ToDouble(Console.ReadLine());

            item.nombre = Nombre;
            item.apellido = Apellido;
            item.telefono = Telefono;

            LChoferes[index - 1] = item;

        }

        private static void EliminarAutobus()
        {
            Console.WriteLine("Seleccione el autobus que desea  Eliminar:");
            MostrarA();
            int index = Convert.ToInt32(Console.ReadLine());

            LAutobus.RemoveAt(index - 1);
        }
        private static void EliminarRuta()
        {
            Console.WriteLine("Seleccione la ruta que desea  Eliminar:");
            MostrarR();
            int index = Convert.ToInt32(Console.ReadLine());

            LRuta.RemoveAt(index - 1);
        }
        private static void EliminarChofer()
        {
            Console.WriteLine("Seleccione el chofer que desea  Eliminar:");
            MostrarC();
            int index = Convert.ToInt32(Console.ReadLine());

            LChoferes.RemoveAt(index - 1);
        }

        private static void asignarAutobuses()
        {
            try {
                if (LChoferes.Count > 0)
                {
                    Console.WriteLine("-----Lista de choferes-----");

                    autobusesAsignados = new List<string>();
                    MostrarC();

                    Console.Write(" Seleccione el chofer que desea asignarle el autobus: ");
                    int index = Convert.ToInt32(Console.ReadLine());


                    string matricula = GetElement(LChoferes, (index - 1));


                    RegistrarAutobus();

                    if (autobusesAsignados.Count <= 0)
                    {
                        Console.WriteLine("No asigno ningun autobus");

                    }
                    string Autobuses = GetElement(LAutobus, (index - 1));

                    if (ValidarAutobuses(Autobuses))
                    {
                        autobusesAsignados.Add(Autobuses);
                        Console.WriteLine("Desea aignar otro autobus S/N ");
                        string seleccion = Console.ReadLine();

                        if (seleccion == "S")
                        {
                            RegistrarAutobus();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Este autobus ya fue asignado");
                        Console.WriteLine("Desea aignar otro autobus S/N ");
                        string seleccion = Console.ReadLine();

                        if (seleccion == "S")
                        {
                            RegistrarAutobus();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No existen choferes en el sistema");

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error " + ex.Message);
               
            }
        }
        private static bool ValidarAutobuses(string autobuseAasignar)
        {

            bool EsValida = true;
            foreach (string Autobuses in autobusesAsignados)
            {
                if (Autobuses == autobuseAasignar)
                {
                    EsValida = false;
                }
            }

            return EsValida;
        }

        private static void Ticket()
        {
            try
            {
                if (LCliente.Count > 0)
                {
                    Console.WriteLine("-----Lista de rutas-----");

                    Tickets = new List<string>();
                    MostrarCL();

                    Console.Write(" Seleccione la ruta deseada: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Que cantidad de tickets desea para esta ruta?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    foreach (Ruta item in LRuta)
                    {
                        cantidad = cantidad * item.costoRuta;
                        Console.WriteLine("Costo : " + cantidad + "$");

                    }

                    string nombre = GetElement(LCliente, (index - 1));
                    RegistrarClientes();



                    if (Tickets.Count <= 0)
                    {
                        Console.WriteLine("No selecciono ninguna ruta");

                    }
                    string ruta = GetElement(LRuta, (index - 1));
                    if (ValidarRuta(ruta))
                    {
                        Tickets.Add(ruta);
                        Console.WriteLine("Desea agregar otra ruta S/N :");
                        string seleccion = Console.ReadLine();
                        if (seleccion == "S")
                        {
                            RegistrarClientes();
                        }
                        else
                        {
                            Console.WriteLine("Esta ruta ya fue seleccionada");
                            Console.WriteLine("Desea seleccionar otra ruta S/N :");
                            if (seleccion == "S")
                            {
                                RegistrarClientes();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen rutas en el sistema");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error " + ex.Message);
            }
        }
            private static bool ValidarRuta(string rutaSeleccionada)
            {

                bool EsValida = true;
                foreach (string ruta in Tickets)
                {
                    if (ruta == rutaSeleccionada)
                    {
                        EsValida = false;
                    }
                }

                return EsValida;
            }
        private static void Reservaciones()
        {
            

            Console.WriteLine("Seleccione una ruta:");
            MostrarR();
            int mostrar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruta Seleccionada" + mostrar);  

            
            
            

        }

        }

       

    }

      
    

