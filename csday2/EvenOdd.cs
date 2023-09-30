//program to check number is even or odd
class IfElseProgram{
    public static void Main()
    {
        Console.WriteLine("Please enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0)
        {
            Console.WriteLine("Even number");
        }
        else{
            Console.WriteLine($"{num} Odd number");
        }   
    }
}