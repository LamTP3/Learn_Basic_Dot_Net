//namespace HelloWord
namespace MyApp.HelloWord
{
    //internal class Program
    /*
     * 
     * 
     */
    public class Program
    {
        static void Main(string[] args)         
        {
            Console.WriteLine("Hello, World!");
            if (args.Length >0)
            {
                foreach(var arg in args)

                {
                    Console.WriteLine(arg);
                }      
            }
           var s = Console.ReadLine();
            //int n = int.Parse(s);
            if (int.TryParse(s, out var val))
                Console.WriteLine(val);
            else
                Console.WriteLine("Invalid int value");
                Console.WriteLine(val);
        }
    }
}
