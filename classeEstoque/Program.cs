namespace classeEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto1 = new Produto("Lapis", 2.50, 500 ) ;
            Produto produto2 = new Produto("Paçoca", 10.50, 500);
            Produto produto3 = new Produto("Chá Baer Matte", 7.99, 500);

                Console.WriteLine(produto1.getDetailProduct());
                Console.WriteLine(produto2.getDetailProduct());
                Console.WriteLine(produto3.getDetailProduct());
            
            Retangulo retangulo = new Retangulo(); //instanciando
            Console.WriteLine("A Area do retangulo é " + retangulo.Area());

           
            Console.WriteLine("O Perimetro do retangulo é " + retangulo.Perimetro());



            ContaCorrente  conta = new ContaCorrente(); //instanciando
            conta.Saldo = 200;
            conta.Numero = 155;
            conta.Titular = "Diego Aquila";
            Console.WriteLine(conta.Deposito(500));
            
            Console.WriteLine (conta.Saque(200));
           
            Console.WriteLine(conta.Saldo);

        }

    }
}
