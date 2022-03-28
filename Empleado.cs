namespace RemuneracionesElectrolitos
{
    // Enumeracion TipoEmpleado
    public enum TipoEmpleado
    {
        JefeTienda = 0,
        VendedorTienda = 1,
        ReponedorTienda = 2
    }
    public class Empleado
    {
        // Atributos
        private TipoEmpleado _empleado;
        private string _nombre;
        private const int _horasMaximo = 40;
        private int _horas;
        private double[] _sueldo;
        private double[] _horasExtra;

        // Constructores
        public Empleado()
        {
            this._empleado = TipoEmpleado.VendedorTienda;
            this._nombre = string.Empty;
            this._horas = _horasMaximo;
            this._sueldo = new double[] { 2000.0, 1500.0, 1000.0 };
            this._horasExtra = new double[] { 3000.0, 2500.0, 2000.0 };
        }
        public Empleado(int horas, TipoEmpleado tipoEmpleado, string nombre) : this()
        {
            Horas = horas;
            EmpleadoTipo = tipoEmpleado;
            Nombre = nombre;
        }

        // Encapsulamiento
        public TipoEmpleado EmpleadoTipo{
            get { return this._empleado; }
            set { this._empleado = value; }
        }
        public string Nombre { 
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int Horas
        {
            get{return this._horas;}
            set{this._horas = value;}
        }
        public int HorasExtra
        {
            get {
                int resultado = this._horas - _horasMaximo;
                return resultado < 0 ? 0 : resultado;
            }
        }
        public double Sueldo{
            get
            {
                if (Math.Abs(_horas) <= _horasMaximo)
                    return _sueldo[(int)_empleado] * _horas;
                else
                    return _horasExtra[(int)_empleado] * _horas;
            }
        }
    }
}
