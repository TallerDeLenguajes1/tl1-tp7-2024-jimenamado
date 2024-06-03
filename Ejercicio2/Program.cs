using EspacioEmpleado;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Cargue los datos para 3 empleados en un arreglo de tipo empleados. 
        //crea una Instancia de empleado 
        Empleado empleado1 = new Empleado("Jimena", "Amado", new DateTime(2000,12,28), 'S', 'F', new DateTime(2020,01,01), 200000, Cargos.Ingeniero);
        Empleado empleado2 = new Empleado("Emir", "Amado", new DateTime(1990,02,06), 'S', 'M', new DateTime(2010,01,01), 240000, Cargos.Administrativo);
        Empleado empleado3 = new Empleado("Elena", "Silva", new DateTime(1972,09,02), 'C', 'F', new DateTime(2000,01,01), 400000, Cargos.Especialista);

        //Monto Total de lo que se paga en concepto de Salarios
        double salario1 = empleado1.CalcularSalario();
        double salario2 = empleado2.CalcularSalario();
        double salario3 = empleado3.CalcularSalario();
        double montoTotalSalarios = (salario1 + salario2 + salario3);
        Console.WriteLine("Concepto de salarios:" + montoTotalSalarios);

        //Mostrar datos del empleado mas prox a jubilarse
        if (empleado1.CalcularAniosJubilacion() <= empleado2.CalcularAniosJubilacion() && empleado1.CalcularAniosJubilacion() <= empleado3.CalcularAniosJubilacion())
        {
            MostrarDatosEmpleado(empleado1);
        }
        else
        {
            if (empleado2.CalcularAniosJubilacion() <= empleado1.CalcularAniosJubilacion() && empleado2.CalcularAniosJubilacion() <= empleado3.CalcularAniosJubilacion())
            {
                MostrarDatosEmpleado(empleado2);
            }
            else
            {
                MostrarDatosEmpleado(empleado3);
            }
        }

    }

    public static void MostrarDatosEmpleado(Empleado empleado)
    {
        Console.WriteLine("---------Datos del Empleado ---------");
        Console.WriteLine("Nombre:" + empleado.Nombre+","+ empleado.Apellido);
        Console.WriteLine("Fecha de nacimiento:"+empleado.FechaNac.ToString("dd/MM/yyyy"));
        if (empleado.EstadoCivil=='S')
        {
            Console.WriteLine("Estado Civil: Soltero");
        }
        else
        {
            Console.WriteLine("Estado Civil: Casado");
        }
        if (empleado.Genero=='F')
        {
            Console.WriteLine("Genero: Femenino");
        }
        else
        {
            Console.WriteLine("Genero: Masculino");
        }
        Console.WriteLine("Fecha de Ingreso a la empresa:"+empleado.FechaIngreso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Cargo:"+empleado.Cargo);
        Console.WriteLine("Antiguedad:"+empleado.CalcularAntiguedad());
        Console.WriteLine("Anios restantes para jubilacion:"+empleado.CalcularAniosJubilacion());
        Console.WriteLine("Sueldo Basico:"+empleado.SueldoBasico);
        Console.WriteLine("Salario:"+empleado.CalcularSalario());
        Console.WriteLine("------------------------------------");
    }

}