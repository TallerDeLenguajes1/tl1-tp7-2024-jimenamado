using EspacioCalculadora;

internal class Program

{
    private static void Main(string[] args)
    {
        
      //constructor para inicializar los objetos de la clase
      Calculadora calc = new Calculadora();
      double numero;    
      int operacion = 0;

      while (operacion != 6)
      {
        Console.WriteLine("Ingrese una operacion");
        Console.WriteLine("1.Sumar");
        Console.WriteLine("2.Restar");
        Console.WriteLine("3.Multiplicar");
        Console.WriteLine("4.Dividir");
        Console.WriteLine("5.Limpiar");
        Console.WriteLine("6.Finalizar");

        string cad1 = Console.ReadLine();
        bool result  = int.TryParse(cad1, out operacion);

        if (!result || operacion < 1 || operacion > 6)
        {       
            Console.WriteLine("Operacion invalida, ingrese nuevamente");
            continue;                                               //en la validación, asegura que el usuario ingrese una operación válida antes de continuar.
        } 
        if (operacion == 6)
        {
            Console.WriteLine("Programa Finalizado");
            break;
        }

        if (result && (operacion >=1  && operacion <= 6))
        {
            Console.WriteLine("Ingrese un numero");
            string cad2 = Console.ReadLine();
            bool result2 = double.TryParse(cad2, out numero);

            if (!result)
            {
               Console.WriteLine("Numero Invalido");

            }else
            {
                switch (operacion)
                {
                    case 1:
                        calc.Sumar(numero);
                        break;
                    case 2:
                        calc.Restar(numero);
                        break;
                    case 3:
                        calc.Multiplicar(numero);
                        break;
                    case 4:
                        calc.Dividir(numero);
                        break;
                    case 5:
                        calc.Limpiar();
                        break;
                }
            }
        }

        Console.WriteLine("Resultado:" +calc.ResultadoOP);

      }

    }
}