

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Intance;
            log.Save("Hello World");
            log.Save("Design Pattern");

            var a = Singleton.Log.Intance;
            var b = Singleton.Log.Intance;

            Console.WriteLine(a == b); // True
        }
    }
}