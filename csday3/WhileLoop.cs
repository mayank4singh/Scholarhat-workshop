//-----Program to sum the digits
﻿class WhileLoop
{
    public static void Main()
    {
        Console.WriteLine("Please Enter A Number:");
        int num = Convert.ToInt32(Console.ReadLine()); //5231

        int sum = 0;
        while (num > 0)
        {
            int ld = num % 10; //1, 3, 2, 5
            sum = sum + ld; // 0 +1, 1+3, 4+2, 6+5

            //updation
            num = num / 10; //523, 52, 5, 0
        }
        Console.WriteLine($"Sum of Digits is {sum}");
    }
}