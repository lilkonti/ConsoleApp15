namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp15\\test.txt";

            File.Create(path).Dispose();

            for (int i = 0; i != 11; i++) 
            {
                string text = File.ReadAllText(path);
                File.WriteAllText(path, text + ", " + Convert.ToString(i));
            }

            if (File.Exists(path)) 
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else { Console.WriteLine("error"); }

            int[] ints = new int[10000];

            Random random = new Random();

            for(int i = 0; i != 10000; ++i)
            {
                ints[i] = random.Next(1, 10000);
            }

            string path_pars = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp15\\pars.txt";

            File.Create(path_pars).Dispose();

            string path_npars = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp15\\npars.txt";

            File.Create(path_npars).Dispose();

            for (int i = 0; i != 10000; ++i)
            {
                if (ints[i] % 2 == 0) 
                {
                    string text = File.ReadAllText(path_pars);
                    File.WriteAllText(path_pars, text + Convert.ToString(ints[i]) + "\n");
                }
                else
                {
                    string text = File.ReadAllText(path_npars);
                    File.WriteAllText(path_npars, text + Convert.ToString(ints[i]) + "\n");
                }
            }

        }
    }
}