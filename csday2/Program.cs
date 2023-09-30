class IfProgram
{
    public static void Main()
    {
        /**** If Example *****/
        Console.WriteLine("Please Enter a Number:");
        int num = Convert.ToInt32(Console.ReadLine());


        if (num > 0)
        {
            Console.WriteLine("Number is greater than zero!");
        }
        Console.WriteLine("Exit!");
    }
}

