

namespace MyApp.HelloWord
{
    public class Program
    {

        //int x;

        static void Main(string[] args)         
        {
            //string s = "sadgdfhga \n\r\t dgsd";
            //string s = @"sadgdfhga \n\r\t dgsd";
            //string s = $"sadgdfhga \n\r\t dgsd {DateTime.Now} \\";
            //s = Console.ReadLine();

            //StringBuilder stringBuilder = new StringBuilder();
            //string s1 = $"sadgdfhga \n\r\t dgsd {DateTime.Now} \\";
            //string s2 = "review";
            //stringBuilder.Append(s1);
            //stringBuilder.Append(s2);

            // string s = stringBuilder.ToString();
            //Console.WriteLine(s);

            //var x = "10";

            //int? x;

            //x = null;
            //Console.WriteLine(x.HasValue.ToString());

            int n;
            int max = int.MinValue;
            Console.Write("So 1: ");
            n = int.Parse(Console.ReadLine());
            if (n > max) { max = n; }

            Console.Write("So 2: ");
            n = int.Parse(Console.ReadLine());
            if (n > max) { max = n; }

            Console.Write("So 3: ");
            n = int.Parse(Console.ReadLine());
            if (n > max) { max = n; }

            Console.WriteLine("So lon nhat la: " + max.ToString());
        }
    }
}
