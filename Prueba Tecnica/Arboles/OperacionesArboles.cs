namespace Prueba_Tecnica.Arboles
{
    public class OperacionesArboles
    {
        public int CalcularPesoTotal(Arbol nodo)
        {
            int pesoTotal = nodo.Peso;
            foreach (var hijo in nodo.subarboles)
            {
                pesoTotal += CalcularPesoTotal(hijo);
            }
            return pesoTotal;
        }

        public double CalcularPesoPromedio(Arbol nodo)
        {
            int pesoTotal = CalcularPesoTotal(nodo);
            int cantidadNodos = ContarNodos(nodo);
            return (double)pesoTotal / cantidadNodos;
        }

        public int ContarNodos(Arbol nodo)
        {
            int count = 1;
            foreach (var hijo in nodo.subarboles)
            {
                count += ContarNodos(hijo);
            }
            return count;
        }

        public int CalcularAltura(Arbol nodo)
        {
            int alturaMaxima = 1;

            if (nodo == null)
            {
                return 0;
            }
            if (nodo.subarboles.Count == 0)
            {
                return alturaMaxima;
            }
            
            foreach (var hijo in nodo.subarboles)
            {
                alturaMaxima = Math.Max(alturaMaxima, CalcularAltura(hijo));
            }
            return alturaMaxima + 1;
        }
    }
}
