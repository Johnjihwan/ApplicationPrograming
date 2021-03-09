using System;
namespace practice
{
    public class app7
    {
        static void Main(string[] args)
        {
            int a = 1243;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "1251234";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.24543";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}
