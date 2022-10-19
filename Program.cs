using System;

Console.WriteLine("Type a word");
string word=Console.ReadLine();
Console.WriteLine("What position would you like to know the letter of?");
int pos = Convert.ToInt32(Console.ReadLine());
ShowCharacter(pos,word);
static void ShowCharacter(int pos,string word)
{
  char letter = (word[pos]);
    Console.WriteLine(letter);
}

Console.WriteLine("What is the wholesale cost?");
double wholeSale = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the markup percentage?(Do not include percentage sign)");
double markup = Convert.ToInt32(Console.ReadLine());
static void CalculateRetail(double wholeSale,double markup)
{
    double retailPrice = (wholeSale * markup) + wholeSale;
    Console.WriteLine($"The Retail Price is {retailPrice}$.");
}

Console.WriteLine("What is the temperature in Fahrenheit?");
int fahrTemp = Convert.ToInt32(Console.ReadLine());


static void Celsius(int fahrTemp)
{
   double celsiusTemp = (5 / 9) * (fahrTemp - 32);
    Console.WriteLine($"The temperature in Celsius is {celsiusTemp}");
}

Console.WriteLine("Type a number and press enter");
int number = Convert.ToInt32(Console.ReadLine());
 static bool isPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}