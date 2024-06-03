namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        const int jubilacionMujer = 60;
        const int jubilacionVaron = 65;

        //Acceso a campos privados (lectura:get y escritura:set)
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }


        //Constructor - this se usa para referirse a los campos de la instancia actual de la clase Empleado
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNacimiento;
            this.EstadoCivil = estadoCivil;
            this.Genero = genero;
            this.FechaIngreso = fechaIngreso;
            this.SueldoBasico = sueldoBasico;
            this.Cargo = cargo;
        }

        //Metodos para calcular: antiguedad,edad y anios de jubilacion.
        public int CalcularAntiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            int antiguedad = fechaActual.Year - fechaIngreso.Year;

            if (fechaActual.Month < fechaIngreso.Month)
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day)
            {
                edad--;
            }
            return edad;
        }

        public int CalcularAniosJubilacion()
        {
            int edad = CalcularEdad();

            if (genero == 'F')
            {
                return (jubilacionMujer - edad);
            }
            else
            {
                return (jubilacionVaron - edad);
            }
        }

        public double CalcularSalario()
        {

            int antiguedad = CalcularAntiguedad();
            double adicional = 0;

            if (antiguedad < 20)
            {
                adicional = ((sueldoBasico * 0.01) * antiguedad);
            }
            else
            {
                adicional = ((sueldoBasico * 0.25) * antiguedad);
                
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional = adicional + adicional * 0.5;
            }

            if (estadoCivil == 'C')
            {
                adicional = adicional + 150000;
            }

            return (adicional + sueldoBasico);
        }

    }
}