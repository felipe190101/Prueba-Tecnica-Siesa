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

    /*public class Program
    {
        public static void Main(string[] args)
        {
            var conversor = new Conversor();
            Console.WriteLine(conversor.ConversordeBases(287,4));
        }
    }*/

}