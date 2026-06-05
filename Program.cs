namespace class_0605_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            Console.WriteLine(p1.GetName());
            p1 = new Teacher();
            Console.WriteLine(p1.GetName());
            string input =Console.ReadLine();
            if (input =="1")
            {
                p1 = new Student();
            }
            else
            {
                p1 = new Teacher();
            }
            Console.WriteLine(p1.GetName());
        }
    }
}
