// See https://aka.ms/new-console-template for more information
using Methods;
using System.Security.Cryptography.X509Certificates;

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine("sumata na chislata e " + Class1.sum(20, 30));
Console.WriteLine("sumata na chislata e " + Class1.sum(3, b));
double sum = Class1.sum(a, b);
Console.WriteLine(sum);


// when the method is static, class.method() is called
static void printMessage() {
    Console.WriteLine("vavedi chislo");
}

// how to create an object of a class

Person p1 = new Person();
p1.PrintPerson();


