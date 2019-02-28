using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string s = Console.ReadLine();

////String.Format("Hello {0} {0}",s);
//Console.WriteLine($"Hello {s}!");
//Console.ReadLine();

//for(int i = 0; i < 41; i++)
//{
//bool div3 = (i % 3) == 0;
//bool div5 = (i % 5) == 0;

//if (div5 && div3)
//    Console.WriteLine("FizzBuzz");
//else if (div5)
//    Console.WriteLine("Buzz");
//else if (div3)
//    Console.WriteLine("Fizz");
//else
//Console.WriteLine(i); 

//char[] vowel_arr = {'a','e','o','i','u','y'};

//string str = Console.ReadLine();
//string str_lowCase = str.ToLower();

//if (str_lowCase.Length != 0)
//{
//    for (int i = 0; i < vowel_arr.Length; ++i)
//    {
//        if (str_lowCase.StartsWith(vowel_arr[i]))
//        {
//            Console.WriteLine("Yes");
//        }
//    }
//}

/*Mandatory task:
Implement a game “Guess number”. Program chooses random number and asks user to input one. 
If user inputs correct number – win, game over; otherwise program prints hint – user’s input
was greater or less, than program’s number. Repeats until user enters correct number.*/

Random rnd = new Random();
int program_number = rnd.Next(1,13);

Console.WriteLine("Guess the number:");

int your_number = Convert.ToInt32(Console.ReadLine());

while (your_number != program_number)
{
    if (your_number > program_number)
    {
        Console.WriteLine("Your number is greater. Enter the less number:");
        your_number = Convert.ToInt32(Console.ReadLine());
    }
    else if (your_number < program_number)
    {
        Console.WriteLine("Your number is less. Enter the greater number:");
        your_number = Convert.ToInt32(Console.ReadLine());
    }
    if (your_number == program_number)
    {
        Console.WriteLine("You won!");
    }
}
}
}
}

