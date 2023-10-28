/*1-Write a C# program to check if the entered number is Armstrong number?

2-Write a C# function to print first 100 numbers in Fibonacci series?

3-Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1

4-How to check if two Strings are anagrams of each other?

5-How to determine if the string has all unique characters.

6-Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210)

7-Write a C# program finds first 10 perfect numbers.
*/

using System.Numerics;

Console.WriteLine();

#region Question1

//sayı 403 ise - 3 haneli bir sayı - (4^3) + (0^3) + (3+3) = 403 - sayı armstrong sayısı
/*int Armstrong = Convert.ToInt32(Console.ReadLine());
int nbr = Armstrong;
int i = 0;
while (nbr / 10 > 0)
{
    nbr = nbr / 10;
    i++;
}

int[] nbr1 = new int[i + 1];
nbr = Armstrong;

for (int j = 0; j <= i; j++)
{
    nbr1[j] = nbr % 10;
    nbr = nbr / 10;
}


int sum = 0;
foreach (var nb in nbr1)
{
    sum += (int)Math.Pow(nb, i+1);
}

if (sum == Armstrong)
    Console.WriteLine("Number is arstrong");

else
    Console.WriteLine("Not");


Console.ReadLine();
*/

#endregion

#region Question2

/*using System.Numerics;

BigInteger[] fib = new BigInteger[100];
fib[0] = 1;
fib[1] = 1;

for (int i = 2; i < 100; i++)
{

    fib[i] = fib[i - 1] + fib[i - 2];
    Console.WriteLine(fib[i]);
}*/

#endregion

#region Question3

#region Way1

/*string input = Console.ReadLine().ToLower();
//ataturk

Dictionary<char, int> characterNumbers = new Dictionary<char, int>();

foreach (char item in input)
{
    if (characterNumbers.ContainsKey(item))
    {
        characterNumbers[item]++;
    }
    else
    {
        characterNumbers[item] = 1;
    }
}

foreach (var item in characterNumbers)
{
    Console.WriteLine($"{item.Key} word = {item.Value} ");
}*/

#endregion

#region Way2

/*Console.WriteLine("Bir string giriniz");
string str = Console.ReadLine();
int count = 0;
int flag = 1;

for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (str[j] == str[i])
        {
            flag = 0;
        }
    }

    if (flag == 1)
    {
        for (int k = i; k < str.Length; k++)
        {
            if (str[k] == str[i])
                count++;
        }

        Console.Write(str[i]);
        Console.Write(" is counted: ");
        Console.WriteLine(count);
        count = 0;
    }

    flag = 1;
}

Console.ReadLine();*/

#endregion

#endregion

#region Question4

/*Console.WriteLine("Enter a word");
var input = Console.ReadLine().ToLower();

Console.WriteLine("Enter a word");
var input2 = Console.ReadLine().ToLower();

if (input.Length != input2.Length)
{
    Console.WriteLine("Not Anagram");
    return;
}

var inputShortedArray = input.ToCharArray();
var inputShortedArray2 = input2.ToCharArray();

Array.Sort(inputShortedArray);
Array.Sort(inputShortedArray2);


for (int i = 0; i < inputShortedArray.Length; i++)
{
    if (inputShortedArray[i] != inputShortedArray2[i])
    {
        Console.WriteLine("Not Anagram");
        return;
    }

}
Console.WriteLine("Anagram");*/

#endregion

#region Question5

/*Console.Write("Input= ");
string input = Console.ReadLine().ToLower();
bool isUnique = true;

for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)  // starts next index
    {
        if (input[i] == input[j])               // compare
        {
            isUnique = false;
            break;
        }
    }
    if (!isUnique)
        break;
}

if (isUnique)
    Console.WriteLine("Unique characters.");
else
    Console.WriteLine("Not unique characters.");*/

#endregion

#region Question6

/*int total1 = 0;
int total2 = 0;
int flag = 2;
for (int i = 2; ; i++)
{
    for (int a = 1; a < i; a++)
    {
        if (i % a == 0)
            total1 += a;
    }

    for (int j = 2; j < i; j++)
    {
        for (int a = 1; a < j; a++)
        {
            if (j % a == 0)
                total2 += a;
        }

        if (total1 == j && total2 == i)
        {
            Console.WriteLine($"{i}, {j}");
            flag--;
        }
        total2 = 0;
    }

    total1 = 0;
    if (flag <= 0)
        break;
}*/

#endregion

#region Question7

#region Way1

/*double total1 = 0;
double flag = 0;
double i = 0;
while (flag < 10)
{
    for (double a = 1; a < i; a++)
    {
        if (i % a == 0)
            total1 += a;
    }

    if (total1 == i)
    {
        Console.WriteLine($"{i}");
        flag++;
    }

    total1 = 0;
    i++;
}*/

#endregion

#region Way2

//int perfectCount = 0;
//while (perfectCount < 10)
//{
//    for (int i = 1; ; i++)
//    {
//        if (IsPerfect(i))
//        {
//            Console.WriteLine(i);
//            perfectCount++;
//        }
//    }
//}


//static bool IsPerfect(int number)
//{
//    int sum = 1;
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum == number;
//}

#endregion




#endregion

BigInteger p = 2;
BigInteger sayac = 1;
while (sayac <= 10)
{
    if (p == 2 || p % 2 == 1)
    {
        Console.WriteLine(PerfectFormula(p));
        p++;
        sayac++;
    }
    else
    {
        p++;
        continue;
    }
}

static BigInteger PerfectFormula(BigInteger p)
{
    return UsAlma(2, p - 1) * (UsAlma(2, p) - 1);
}
static BigInteger UsAlma(BigInteger taban, BigInteger us)
{
    BigInteger sonuc = 1;
    for (BigInteger i = 0; i < us; i++)
    {
        sonuc *= taban;
    }
    return sonuc;
}

Console.ReadKey();