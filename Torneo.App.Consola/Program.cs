using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT _repoDT = new RepositorioDT();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("   ----MENU----");
                Console.WriteLine("1. Insertar municipio");
                Console.WriteLine("2. Insertar director tecnico");
                Console.WriteLine("3. Insertar equipo");
                Console.WriteLine("4.Insertar posicion");
                Console.WriteLine("5.Insertar jugador");
                Console.WriteLine("6.Insertar arbitro");
                Console.WriteLine("7.Insertar estadio");
                Console.WriteLine("8.Insertar partido");
                Console.WriteLine("9.Mostrar municipios");
                Console.WriteLine("10.Mostrar DTs");
                Console.WriteLine("11.Mostrar Equipos");
                Console.WriteLine("12.Mostrar Posiciones");
                Console.WriteLine("13.Mostrar Jugadores");
                Console.WriteLine("14.Mostrar Arbitros");
                Console.WriteLine("15.Mostrar Estadios");
                Console.WriteLine("16.Mostrar Partidos");
                Console.WriteLine("0. Salir");

                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddDT();
                        break;
                    case 3:
                        AddEquipo();
                        break;
                    case 4:
                        AddPosicion();
                        break;
                    case 5:
                        AddJugador();
                        break;
                    case 6:
                        AddArbitro();
                        break;
                    case 7:
                        AddEstadio();
                        break;
                     case 8:
                        AddPartido();
                        break;
                    case 9:
                        GetAllMunicipios();
                        break;
                    case 10:
                        GetAllDTs();
                        break;
                    case 11:
                        GetAllEquipos();
                        break;
                    case 12:
                        GetAllPosiciones();
                        break;
                    case 13:
                        GetAllJugadores();
                        break;
                    case 14:
                        GetAllArbitros();
                        break;
                    case 15:
                        GetAllEstadios();
                        break;
/*                      case 16:
                        GetAllPartidos();
                        break; */
                }
            } while (opcion != 0);
        }

        private static void AddMunicipio()
        {
            Console.WriteLine("Escriba el nombre del municipio");
            string nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void AddDT()
        {
            Console.WriteLine("Escriba el nombre del DT");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el documento del DT");
            string documento = Console.ReadLine();
            Console.WriteLine("Escriba el telefono del DT");
            string telefono = Console.ReadLine();
            var directorTecnico = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDT.AddDT(directorTecnico);
        }

        private static void AddEquipo()
        {
            Console.WriteLine("Escriba el nombre del equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el id del municipio");
            int idMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el id del DT");
            int idDT = Int32.Parse(Console.ReadLine());

            var equipo = new Equipo
            {
                Nombre = nombre,
            };
            _repoEquipo.AddEquipo(equipo, idMunicipio, idDT);
        }

        private static void AddPosicion()
        {
            Console.WriteLine("Escriba el nombre de la posicion");
            string nombre = Console.ReadLine();
            var posicion = new Posicion
            {
                Nombre = nombre,
            };
            _repoPosicion.AddPosicion(posicion);
        }

        public static void AddJugador()
        {
            Console.WriteLine("Escriba el nombre del Jugador");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el numero del Jugador");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el id del equipo");
            int idEquipo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el id de la posicion");
            int idPosicion = Int32.Parse(Console.ReadLine());
            
            var jugador = new Jugador
            {
                Nombre = nombre,
                Numero = numero,
            };
            _repoJugador.AddJugador(jugador, idEquipo, idPosicion);

        }

        private static void AddArbitro()
        {
            Console.WriteLine("Escriba el nombre del arbitro");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el documento del arbitro");
            string documento = Console.ReadLine();
            Console.WriteLine("Escriba el telefono del arbitro");
            string telefono = Console.ReadLine();
            Console.WriteLine("Escriba el colegio del arbitro");
            string colegio = Console.ReadLine();

            var arbitro = new Arbitro
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
                Colegio = colegio,
            };
            _repoArbitro.AddArbitro(arbitro);
        }

        private static void AddEstadio()
        {
            Console.WriteLine("Escriba el nombre del estadio");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba la direccion del estadio");
            string direccion = Console.ReadLine();
            Console.WriteLine("Escriba el id del municipio");
            int idMunicipio = Int32.Parse(Console.ReadLine());

            var estadio = new Estadio
            {
                Nombre = nombre,
                Direccion = direccion,
            };
            _repoEstadio.AddEstadio(estadio, idMunicipio);
        }

        public static void AddPartido()
        {

            /* Console.WriteLine("Escriba el año del partido");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el mes del partido");
            int mes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el dia del partido");
            int dia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la hora del partido");
            int hora = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el munito del partido");
            int minuto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo del partido");
            int segundo = Int32.Parse(Console.ReadLine());
            DateTime fechaHora = new DateTime(year, mes, dia, hora, minuto, segundo); */
            //string fecha = "2022/12/12 14:00:00";
            //DateTime fechaHora = DateTime.Parse(fecha);
            Console.WriteLine("Escriba la fecha y hora del partido, en formato (AAAA/MM/DD HH:MM:SS)");
            DateTime fechaHora = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el id del equipo local");
            int local = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el id del equipo visitante");
            int visitante = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el id del estadio");
            int idEstadio = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el id del partido");
            int idArbitro = Int32.Parse(Console.ReadLine());

            var partido = new Partido
            {
                FechaHora = fechaHora,
                MarcadorLocal = 0,
                MarcadorVisitante = 0,
            };
            _repoPartido.AddPartido(partido, local, visitante, idEstadio, idArbitro);

        }

        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }

        private static void GetAllDTs()
        {
            foreach (var dt in _repoDT.GetAllDTs())
            {
                Console.WriteLine(dt.Id + " " + dt.Nombre + " " + dt.Documento + " " + dt.Telefono);
            }
        }

        private static void GetAllEquipos()
        {
            foreach (var equipo in _repoEquipo.GetAllEquipos())
            {
                Console.WriteLine(equipo.Id + " " + equipo.Nombre
                + " " + equipo.Municipio.Nombre + " " + equipo.DirectorTecnico.Nombre);
            }
        }

        private static void GetAllPosiciones()
        {
            foreach (var posicion in _repoPosicion.GetAllPosiciones())
            {
                Console.WriteLine(posicion.Id + " " + posicion.Nombre);
            }
        }

        private static void GetAllJugadores()
        {
            foreach (var jugador in _repoJugador.GetAllJugadores())
            {
                Console.WriteLine(jugador.Id + " " + jugador.Nombre + " " + jugador.Numero + " " + jugador.Equipo.Nombre + " " + jugador.Posicion.Nombre );
            }
        }

        private static void GetAllArbitros()
        {
            foreach (var arbitro in _repoArbitro.GetAllArbitros())
            {
                Console.WriteLine(arbitro.Id + " " + arbitro.Nombre + " " + arbitro.Documento + " " + arbitro.Telefono +" "+ arbitro.Colegio);
            }
        }

        private static void GetAllEstadios()
        {
            foreach (var estadio in _repoEstadio.GetAllEstadios())
            {
                Console.WriteLine(estadio.Id + " " + estadio.Nombre + " " + estadio.Direccion +" "+ estadio.Municipio.Nombre);
            }
        }

/*         private static void GetAllPartidos()
        {
            foreach (var partido in _repoPartido.GetAllPartidos())
            {
                Console.WriteLine(partido.Id + " " + partido.FechaHora + " " + partido.Local.Nombre +" "+ partido.MarcadorLocal +" "+ 
                +" "+ partido.Visitante.Nombre +" "+ partido.MarcadorVisitante +" "+ partido.Arbitro.Nombre +" "+ partido.Estadio.Nombre);
            }
        } */
    }
}