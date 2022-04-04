namespace RemuneracionesElectrolitos {
    public class Program
    {
        private static List<Empleado> empleados = new List<Empleado>();

        private static void ImprimirConsola()
        {
            Console.WriteLine("Elija una opcion:\n");
            Console.WriteLine("1. Consultar usuario.");
            Console.WriteLine("2. Ingresar usuario.\n");
            Console.WriteLine("0. Salir\n");
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                ImprimirConsola();
                int peticion = 0;
                int.TryParse(Console.ReadLine(), out peticion);
                Console.Clear();
                switch (peticion)
                {
                    case 0:
                        // Salir
                        Console.WriteLine("Cerrando programa..");
                        return;
                    case 1:
                        // Consulta de datos
                        foreach(Empleado emp in empleados){
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("Nombre: " + emp.Nombre);
                            Console.WriteLine("Tipo empleado: " + emp.EmpleadoTipo.ToString());
                            Console.WriteLine("Sueldo: " + emp.Sueldo);
                            Console.WriteLine("Horas trabajadas: " + emp.Horas);
                            Console.WriteLine("Horas extra: " + emp.HorasExtra);
                            Console.WriteLine("_________________________________");
                        }
                        break;
                    case 2:
                        // Ingreso de datos
                        // (int horas, TipoEmpleado tipoEmpleado, string nombre)
                        Console.WriteLine("Ingrese el nombre del empleado: \n");
                        string? input = Console.ReadLine();
                        if (String.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("El nombre de empleado ingresado no es válido.");
                            break;
                        }
                        string nombre = input;

                        // Tipo Empleado
                        Console.WriteLine("Seleccione el tipo de empleado: \n");
                        Console.WriteLine("1. Jefe de Tienda.\n");
                        Console.WriteLine("2. Vendedor.\n");
                        Console.WriteLine("3. Reponedor.\n");

                        int inputNum = -1;
                        bool opcionTipoEmpleado = int.TryParse(Console.ReadLine(), out inputNum);
                        bool opcionTipoEmpleadoEntreUnoYTres = (Math.Abs(inputNum) >= 1 && Math.Abs(inputNum) <= 3);
                        if (!opcionTipoEmpleado || !opcionTipoEmpleadoEntreUnoYTres)
                        {
                            Console.WriteLine("El tipo de empleado ingresado no es válido.");
                            break;
                        }
                        
                        TipoEmpleado tipoEmpleado = 
                            inputNum == 1 ? TipoEmpleado.JefeTienda :
                            inputNum == 2 ? TipoEmpleado.VendedorTienda :
                            inputNum == 3 ? TipoEmpleado.ReponedorTienda :
                            TipoEmpleado.SinRol;
                        /*
                        switch (inputNum)
                        {
                            case 1:
                                tipoEmpleado = TipoEmpleado.JefeTienda;
                                break;
                            case 2:
                                tipoEmpleado = TipoEmpleado.VendedorTienda;
                                break;
                            case 3:
                                tipoEmpleado = TipoEmpleado.ReponedorTienda;
                                break;
                            default:
                                tipoEmpleado = TipoEmpleado.SinRol;
                                break;
                        }*/


                        // Horas trabajadas
                        int horas = 0;
                        Console.WriteLine("Ingrese las horas del empleado:\n");
                        int.TryParse(Console.ReadLine(), out horas);

                        // Instanciar un Empleado
                        Empleado empleado = new Empleado();
                        empleado.Nombre = nombre;
                        empleado.EmpleadoTipo = tipoEmpleado;
                        empleado.Horas = horas;
                        
                        // Guardar instancia dentro del List<Empleado> empleados
                        empleados.Add(empleado);
                        Console.Clear();
                        break;
                }
                
            }
        }
    }
}