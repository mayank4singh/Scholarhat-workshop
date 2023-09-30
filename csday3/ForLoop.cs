class ForLoop{
    public static void Main(){
        Console.WriteLine("Please Enter a Number for Star Pattern:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}