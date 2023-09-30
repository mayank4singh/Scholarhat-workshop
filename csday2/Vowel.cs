//To check whether a number is vowel or consonant
class VOWELS{
    public static void Main(){
        Char ch;
        Console.WriteLine("Enter An Alphabet");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        switch(ch)
        {
            case 'a':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'e':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'i':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'o':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'u':
                Console.WriteLine("The Alphabet is vowel");
                break;       
            default:
                Console.WriteLine("The Alphabet is not Vowel");
                break;        
        }
    }    
}