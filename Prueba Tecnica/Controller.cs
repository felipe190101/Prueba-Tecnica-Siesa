using Prueba_Tecnica.Arboles;
using pruebaTecnica;

namespace Prueba_Tecnica
{
    internal class Controller
    {
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //Ejecucion Ejercicio de division de dos numeros
            var prueba = new Prueba();
            Console.WriteLine("Resultado Ejercicio de division de dos numeros");
            Console.WriteLine(prueba.division(10, 2));

            //Ejecucion Ejercicio de convertir un decimal a base n
            var conversor = new Conversor();
            Console.WriteLine("Resultado Ejercicio de convertir un decimal a base n");
            Console.WriteLine(conversor.ConversordeBases(287, 4));

            //Ejecucion Ejercicio de arboles

            //Caso de prueba Arbol 1
            var arbol = new Arbol(4);

            var operaciones = new OperacionesArboles();
            Console.WriteLine("Caso de prueba 1 ejercicio arboles");
            Console.WriteLine(operaciones.CalcularPesoTotal(arbol));
            Console.WriteLine(operaciones.CalcularPesoPromedio(arbol));
            Console.WriteLine(operaciones.CalcularAltura(arbol));

            //Caso de prueba Arbol 2

            var arbol2 = new Arbol(4);
            Arbol hijo1 = new Arbol(2);
            Arbol hijo2 = new Arbol(1);

            arbol2.AgregarSubArbol(hijo1);
            arbol2.AgregarSubArbol(hijo2);
            Console.WriteLine("Caso de prueba 2 ejercicio arboles");
            Console.WriteLine(operaciones.CalcularPesoTotal(arbol2));
            Console.WriteLine(operaciones.CalcularPesoPromedio(arbol2));
            Console.WriteLine(operaciones.CalcularAltura(arbol2));

            //Caso de prueba Arbol 3

            var arbol3 = new Arbol(4);
            Arbol hijo7 = new Arbol(1);
            Arbol hijo8 = new Arbol(2);
            Arbol hijo3 = new Arbol(5);

            Arbol hijo4 = new Arbol(3);
            hijo8.AgregarSubArbol(hijo4);

            Arbol hijo5 = new Arbol(1);
            Arbol hijo6 = new Arbol(4);
            hijo3.AgregarSubArbol(hijo5);
            hijo3.AgregarSubArbol(hijo6);

            arbol3.AgregarSubArbol(hijo7);
            arbol3.AgregarSubArbol(hijo8);
            arbol3.AgregarSubArbol(hijo3);

            Console.WriteLine("Caso de prueba 3 ejercicio arboles");
            Console.WriteLine(operaciones.CalcularPesoTotal(arbol3));
            Console.WriteLine(operaciones.CalcularPesoPromedio(arbol3));
            Console.WriteLine(operaciones.CalcularAltura(arbol3));

        }
    }
}
