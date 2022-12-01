System.Console.WriteLine("start value");
int n = int.Parse(Console.ReadLine()!);

int x = 1;

do
{
    x++;
   
    if (n % 2 == 0)
    {
        n = n / 2;

    }
    else { n = (3 * n) + 1; }
   

}

while (n != 1);
    System.Console.WriteLine($" the length of sequence  is {x}.");


