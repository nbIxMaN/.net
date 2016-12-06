namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new System.Random();
            System.Console.WriteLine("Я – интеллектуальный калькулятор!");
            System.Console.WriteLine("Как тебя зовут?");
            var name = System.Console.ReadLine();
            var first = r.Next(1, 10);
            var second = r.Next(1, 10);
            System.Console.WriteLine("Сколько будет {0} + {1}?", first, second);
            while (true)
            {
                try {
                    var answer = int.Parse(System.Console.ReadLine());
                    if (answer == first + second)
                    {
                        System.Console.WriteLine("Верно, {0}!", name);
                        break;
                    }
                    else
                        System.Console.WriteLine("{0}, ты не прав", name);
                }
                catch
                {
                    System.Console.WriteLine("Введи число, {0}", name);
                }
            }
        }
    }
}
