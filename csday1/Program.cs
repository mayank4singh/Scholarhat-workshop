//-----A program to add two numbers-----
/*int num1, num2;

Console.WriteLine("Please Enter First Number");
num1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Second Number");
num2 =Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine("Sum " +sum);*/
//Swapping two numbers value
/*int num1, num2; //swap;

Console.WriteLine("Please Enter First Number");
num1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Second Number");
num2 =Convert.ToInt32(Console.ReadLine());
//Using the third variable
/*swap = num1;
num1 = num2;
num2 = swap;*/

//-----Without using the third variable-----

/*num1 = num1+num2;
num2 = num1 - num2;
num1 = num1 - num2;

Console.WriteLine("First Number" +num1);
Console.WriteLine("Second Number" +num2);*/

//-----Program to print the table of a number-----
/*int n , m;

Console.WriteLine("Please Enter Number for table: ");
n = Convert.ToInt32(Console.ReadLine());

m = n;
n=m*1;
Console.WriteLine(m+" X 1 = "+n);
n=m*2;
Console.WriteLine(m+" X 2 = "+n);
n=m*3;
Console.WriteLine(m+" X 3 = "+n);
n=m*4;
Console.WriteLine(m+" X 4 = "+n);
n=m*5;
Console.WriteLine(m+" X 5 = "+n);
n=m*6;
Console.WriteLine(m+" X 6 = "+n);
n=m*7;
Console.WriteLine(m+" X 7 = "+n);
n=m*8;
Console.WriteLine(m+" X 8 = "+n);
n=m*9;
Console.WriteLine(m+" X 9 = "+n);
n=m*10;
Console.WriteLine(m+" X 10 = "+n);*/

//-----Enter a four digit number  and sum all its digit-----

Console.WriteLine("Please Enter 4 digit number");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int ld = 0;

ld = num % 10;
sum = sum + ld;
num = num / 10;

ld = num % 10;
sum = sum + ld;
num = num / 10;

ld = num % 10;
sum = sum + ld;
num = num / 10;

ld = num % 10;
sum = sum + ld;

Console.WriteLine($"Sum of Digits: (sum)");



