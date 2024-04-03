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
    }
}
