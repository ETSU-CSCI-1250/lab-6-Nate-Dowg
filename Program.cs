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
double wholeSale = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the markup percentage?(Write as decimal)");
double markup = Convert.ToDouble(Console.ReadLine());
CalculateRetail(wholeSale, markup);
static void CalculateRetail(double wholeSale,double markup)
{
    double retailPrice = (wholeSale * markup) + wholeSale;
    Console.WriteLine($"The Retail Price is {retailPrice}$.");
}

Console.WriteLine("What is the temperature in Fahrenheit?");
int fahrTemp = Convert.ToInt32(Console.ReadLine());
Celsius(fahrTemp);
static void Celsius(int fahrTemp)
{
   double celsiusTemp = (fahrTemp - 32) / 1.8;
    Console.WriteLine($"The temperature in Celsius is {celsiusTemp}");
}







     int n, i, m = 0, flag = 0;
    Console.Write("Enter the Number to check Prime: ");
    n = int.Parse(Console.ReadLine());
    m = n / 2;
    for (i = 2; i <= m; i++)
    {
        if (n % i == 0)
        {
            Console.Write("Number is not Prime.");
            flag = 1;
            break;
        }
    }
    if (flag == 0)
        Console.Write("Number is Prime.");  
