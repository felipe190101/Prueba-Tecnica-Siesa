using pruebaTecnica;

namespace Prueba_Tecnica.Arboles
{
    public class Arbol
    {

        public int Peso;
        public List<Arbol> subarboles;

        public Arbol(int Peso)
        {
            this.Peso = Peso;
            subarboles = new List<Arbol>();
        }

        public void AgregarSubArbol(Arbol subarbol)
        {
            subarboles.Add(subarbol);
        }

        /*public class ProgramArboles
        {
            public static void Main(string[] args)
            {
                //Caso de prueba Arbol 1
                var arbol = new Arbol(4);
               
                var operaciones = new OperacionesArboles();
                Console.WriteLine(operaciones.CalcularPesoTotal(arbol));
                Console.WriteLine(operaciones.CalcularPesoPromedio(arbol));
                Console.WriteLine(operaciones.CalcularAltura(arbol));*/

                //Caso de prueba Arbol 2

                /*var arbol = new Arbol(4);
                Arbol hijo1 = new Arbol(2);
                Arbol hijo2 = new Arbol(1);

                arbol.AgregarSubArbol(hijo1);
                arbol.AgregarSubArbol(hijo2);
                var operaciones = new OperacionesArboles();
                Console.WriteLine(operaciones.CalcularPesoTotal(arbol));
                Console.WriteLine(operaciones.CalcularPesoPromedio(arbol));
                Console.WriteLine(operaciones.CalcularAltura(arbol));

                //Caso de prueba Arbol 3

                var arbol = new Arbol(4);
                Arbol hijo1 = new Arbol(1);
                Arbol hijo2 = new Arbol(2);
                Arbol hijo3 = new Arbol(5);

                Arbol hijo4 = new Arbol(3);
                hijo2.AgregarSubArbol(hijo4);

                Arbol hijo5 = new Arbol(1);
                Arbol hijo6 = new Arbol(4);
                hijo3.AgregarSubArbol(hijo5);
                hijo3.AgregarSubArbol(hijo6);

                arbol.AgregarSubArbol(hijo1);
                arbol.AgregarSubArbol(hijo2);
                arbol.AgregarSubArbol(hijo3);

                var operaciones = new OperacionesArboles();
                Console.WriteLine(operaciones.CalcularPesoTotal(arbol));
                Console.WriteLine(operaciones.CalcularPesoPromedio(arbol));
                Console.WriteLine(operaciones.CalcularAltura(arbol));
            }
        }*/
    }
}
