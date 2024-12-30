// See https://aka.ms/new-console-template for more information



/*Console.WriteLine(" Introduceti primul numar:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Introduceti al doilea numar:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Introduceti al treilea numar:");
int z = Convert.ToInt32(Console.ReadLine());

if (x<y)
{
    int temp = x;
    x = y;
    y = temp;
}
if (x<z)
{
    int temp = x;
    x = z;
    z = temp;
}
if (y<z)
{
    int temp = y;
    y = z;
    z = temp;
}
Console.WriteLine("Cele trei numere descrescatoare in ordine sunt:");
Console.WriteLine(x + "," + y + "," + z);*/


/*Console.WriteLine("introduceti numarul:");
int x = int.Parse (Console.ReadLine());
int suma = x % 10 + x / 10;
Console.WriteLine("Suma cifrelor numarului este: " + suma);
Console.ReadKey();*/


/*Console.WriteLine(" Introduceti numarul:");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.WriteLine("Unu");
        break;
    case 2:
        Console.WriteLine("Doi");
        break;
    case 3:
        Console.WriteLine("Trei");
        break;
    case 5:
        Console.WriteLine("Cinci");
        break;
    case 8:
        Console.WriteLine("Opt");
        break;
    default:
        Console.WriteLine("neidentificat");
        break;
}*/

/*exercitii laborator 2 */


/*int x = int.Parse(Console.ReadLine());
 if (x > 0)
        throw new ArgumentException("Numarul trebuie sa fie negativ.");
    if (x % 2 == 0 && x % 6 != 0)
    {
        Console.WriteLine("Intruneste conditiile");
    }
    else
    {
        Console.WriteLine("Nu intruneste conditiile");
    }*/



/*Console.WriteLine("Introduceti numarul: ");
        int number = int.Parse(Console.ReadLine());
        int suma = SumaCifrelor(number);
        Console.WriteLine($"Suma cifrelor numarului este: {suma}");
int SumaCifrelor(int num)
    {
        int suma = 0;
        while (num != 0)
        {
            suma += num % 10;
            num /= 10;
        }
        return suma;
    }*/

/*Console.WriteLine("Introduceti un numar: ");
int numar = int.Parse(Console.ReadLine());
long rezultat = CalculateFactorial(numar);
Console.WriteLine($"Factorialul lui {numar} este {rezultat}");
    

    long CalculateFactorial(int n)
{
    if (n < 0)
        throw new ArgumentException("Numarul trebuie sa fie pozitiv.");
    if (n == 0 || n == 1)
        return 1;
    return n * CalculateFactorial(n - 1);
}*/

/*List<int> numbers = new List<int>();
Console.WriteLine("Enter natural numbers (type 'done' to finish):");

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "done")
        break;

    if (int.TryParse(input, out int number) && number > 0)
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Please enter a valid natural number.");
    }
}

var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

if (evenNumbers.Count > 0)
{
    double average = evenNumbers.Average();
    Console.WriteLine($"The average of the even numbers is: {average}");
}
else
{
    Console.WriteLine("There are no even numbers in the series.");
}*/

/*Console.WriteLine("Introduceti cate numere doriti");
int n = int.Parse(Console.ReadLine());
List<int> numerePare = new List<int>();
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Introduceti numarul: " + (i + 1));
    int numar = int.Parse(Console.ReadLine());
    if ( numar > 0 &&  numar % 2 == 0 ) { numerePare.Add(numar); }
}
if (numerePare.Count > 0)
{
    double average = numerePare.Average();
    Console.WriteLine($"Media numerelor pare naturale este: {average}");
}
else { Console.WriteLine("Nu exista numere pare naturale in serie");
    }*/

/*Console.WriteLine("Introduceti un numar:");
int numar = int.Parse(Console.ReadLine());
if (IsPalindrome(numar))
{
    Console.WriteLine($"{numar} este un palindrom.");
}
else
{
    Console.WriteLine($"{numar} nu este un palindrom.");
}  bool IsPalindrome(int numar)
{
    int originalNumar = numar;
    int reversedNumar = 0; while (numar > 0)
    {
        int remainder = numar % 10;
        reversedNumar = (reversedNumar * 10) + remainder; numar /= 10;
    }
    return originalNumar == reversedNumar;
}*/

/*Console.WriteLine("Introduceti trei numere:");
int[] numbers = new int[3];
for (int i = 0; i < 3; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Array.Sort(numbers); Array.Reverse(numbers);
Console.WriteLine("Numerele sortate in ordine descrescatoare sunt:");
foreach (int number in numbers) { Console.WriteLine(number); }*/

/*Console.WriteLine("Introduceti un numar x:");
double x = double.Parse(Console.ReadLine());
double result; if (x < -2)
{
    result = 7 * Math.Pow(x, 2);
}
else if (x >= -2 && x <= 0.5)
{
    result = 4 * x - 5;
}
else
{
    result = 14 * x - 7;
}
Console.WriteLine($"Rezultatul este: {result}"); */

