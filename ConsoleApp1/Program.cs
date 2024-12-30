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

/*var x = int.MaxValue;
x = x + 1;
    Console.WriteLine(x);*/

/*double cuvirgula = 2.3;
decimal cuVirgulaDecimal = 2.3M;
cuvirgula = (double)cuVirgulaDecimal;
Console.WriteLine(cuvirgula);*/

/*int x = 3;
int y = 2;
double cuVirgula = (double)x / y;
Console.WriteLine(cuVirgula);*/

/*int x = int.Parse(Console.ReadLine());
if (x % 2 == 0 && x % 5 == 0)
        {
    Console.WriteLine("Divizibil cu 10");
}
else Console.WriteLine("non-divizibil");*/

/*int i = 1;
while (i<=10)
{
Console.WriteLine(i);
    i = i + 1;
}
Console.WriteLine("Gata");*/

/*Console.WriteLine("Introduceti cate numere doriti");
int n = int.Parse(Console.ReadLine());

int i = 0;
while (i < n)
{
    Console.WriteLine(i);
    i = i + 1;
}*/

/*Console.WriteLine("Introduceti cate numere doriti");
int n = int.Parse(Console.ReadLine());
int i = 0;
int suma = 0;
while (i < n)
{
    Console.WriteLine("Introduceti numarul: " + i);
    int numar = int.Parse(Console.ReadLine());
    suma = suma + numar;

    i = i + 1;
}
Console.WriteLine("Suma numerelor este " + suma);*/

/*Console.WriteLine("Introduceti cate numere doriti");
int n = int.Parse(Console.ReadLine());
int i = 0;
int suma = 0;
for (; i < n; i++)
{
    Console.WriteLine("Introduceti numarul: " + i);
    int numar = int.Parse(Console.ReadLine());
    suma += numar;
}
Console.WriteLine("Suma numerelor este " + suma);*/


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
