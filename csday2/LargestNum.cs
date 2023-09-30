class LargestNumber{
    public static void Main()
    {
        Console.WriteLine("Please Enter First Number");
        int num1 = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("Please Enter Second Number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Third Number");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if(num1>num2 && num1>num3){
            Console.WriteLine($"{num1} is largest");
        }
        else if(num2>num1 && num2>num3){
            Console.WriteLine($"{num2} is largest");
        }
        else{
            Console.WriteLine($"{num3} is largest");
        }

    } 
}