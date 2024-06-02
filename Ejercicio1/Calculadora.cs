namespace EspacioCalculadora;

public class Calculadora{

    private double resultado=0;
    
    //metodos 
    public void Sumar(double termino){

        resultado = resultado + termino;
    }
    public void Restar( double termino){

        resultado = resultado - termino;
    }
    public void Multiplicar(double termino){

        resultado = resultado * termino;

    }
    public void Dividir(double termino){

        if (termino != 0)
        {
            resultado = resultado/termino; 
        }else
        {
            Console.WriteLine("Indefinido");
        }
    }

    public void Limpiar(){

        resultado = 0;
    }

    //uso de propiedades: get (solo lectura) obtener el valor
    public double ResultadoOP{
        
        get => resultado;       // get { return resultado; }
    }
}

        






