namespace ConsoleApp1301
{
    internal class Program
    {
        //TODO: Daha çook iş var
        //Fix: Ne
        static void Main(string[] args)
        {
            Program p = new Program();
            p.func1();
        }

        public void func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(500);
                if (i == 8)
                {
                    System.Diagnostics.Debugger.Launch();
                    //System.Diagnostics.Debugger.Break();
                }

                //System.Diagnostics.Debugger.Launch();
            }
        }
    }
}