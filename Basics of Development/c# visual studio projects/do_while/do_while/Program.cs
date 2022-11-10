// See https://aka.ms/new-console-template for more information

using do_while;


for(int i = 0; i < 5; i++)
{
    Console.WriteLine("OK");
}

int a = 0;
while (a < 5)
{
    Console.WriteLine(a);
    a++;
};

int b = 5;
while (b < 5)
{
    Console.WriteLine(b);
    b++;
}


do
{
    Console.WriteLine("No");
    b++;
} while (b < 5);