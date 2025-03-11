namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]; //arrays (antigos vetores)
            double[] notas = new double[8];
            string[] arrayFrutas = { "banana", "maçã", "pera" };

            Console.WriteLine(string.Join("-",arrayFrutas)); //método Join 

            Console.WriteLine(arrayFrutas[1]);

            List<string> fruitlist = new List<string>();
            fruitlist.Add("banana");
            fruitlist.Add("maçã");                                              //Listas
            fruitlist.Add("pera");

            foreach (string fruta in fruitlist) //foreach (para cada)

            {
                Console.WriteLine(fruta);
            }
        }
    }
}
