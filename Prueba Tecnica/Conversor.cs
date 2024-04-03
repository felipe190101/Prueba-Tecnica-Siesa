namespace pruebaTecnica
{
    public class Conversor
    {
        public string ConversordeBases(int numeroDecimal, int baseDestino)
        {
            string resultado = "";

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % baseDestino;
                resultado = residuo.ToString() + resultado;
                numeroDecimal /= baseDestino;
            }
            return resultado == "" ? "0" : resultado;
        }
    }
}