namespace ProducatorConsumator
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProducatorConsumator();
        }
    }
    public class ProducatorConsumator
    {
        int stoc = 0;
        static ManualResetEvent stocGol = new ManualResetEvent(false);
        static ManualResetEvent stocPlin = new ManualResetEvent(false);

        public ProducatorConsumator()
        {
            stocGol.Set();
            Thread tProd = new Thread(new ThreadStart(Producator));
            Thread tCons = new Thread(new ThreadStart(Consumator));
            tProd.Start();
            tCons.Start();
            Console.ReadLine();
        }

        public void Producator()
        {
            

            while (true) 
            {
                stocGol.WaitOne();
                Console.WriteLine("Producator incepe...");

                for (int i = 1; i < 11; i++)
                {
                    stoc++;
                    Console.WriteLine(stoc);
                    Thread.Sleep(500);
                }
                stocPlin.Set();
                stocGol.Reset();
            }

            
        }

        public void Consumator()
        {
            while (true)
            {
                stocPlin.WaitOne();
                Console.WriteLine("Consumator incepe...");

                for (int i = 1; i < 11; i++)
                {
                    stoc--;
                    Console.WriteLine(stoc);
                    Thread.Sleep(500);
                }
                stocGol.Set();
                stocPlin.Reset();
            }

        }

    }
}