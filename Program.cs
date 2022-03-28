namespace RemuneracionesElectrolitos {
    public class Program
    {
        private static List<Empleado> empleados = new List<Empleado>(10);

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elija una opcion:\n");
                Console.WriteLine("1. Consultar usuario.");
                Console.WriteLine("2. Ingresar usuario.\n");
                Console.WriteLine("0. Salir\n");
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
                        foreach(Empleado empleado in empleados){
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("Nombre: " + empleado.Nombre);
                            Console.WriteLine("Tipo empleado: " + empleado.EmpleadoTipo.ToString());
                            Console.WriteLine("Sueldo: " + empleado.Sueldo);
                            Console.WriteLine("Horas trabajadas: " + empleado.Horas);
                            Console.WriteLine("Horas extra: " + empleado.HorasExtra);
                            Console.WriteLine("_________________________________");
                        }
                        break;
                    case 2:
                        // Ingreso de datos
                }
                
            }
        }
    }
}