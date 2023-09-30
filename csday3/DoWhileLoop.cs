class DoWhileLoop
{
     public static void Main()
    {
        char ch;
        do
        {
            Console.Clear();

            Console.WriteLine("Please Enter Your Name:");

            string? name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}");

            Console.WriteLine("Do you want to continue:(y/n)");
            ch = Convert.ToChar(Console.ReadLine());
        } while (ch == 'y');
        Console.WriteLine("Exit");
    }
}