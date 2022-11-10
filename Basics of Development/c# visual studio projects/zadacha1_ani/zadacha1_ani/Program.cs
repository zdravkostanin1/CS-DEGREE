// See https://aka.ms/new-console-template for more information

// bool evenDB = false;
// bool oddDB = false;
Console.WriteLine("Vavedi cenata na telefona:");
int phonePrice = int.Parse(Console.ReadLine());
int money = 0;
Console.WriteLine("Vavedi godini:");
int years = int.Parse(Console.ReadLine());
int moneyBobi = 0;


//for (int y = 0; ; y++) { 
//    if (y % 2 == 0)
//    {
        
//    }
//}

for (int i = 0; i <= phonePrice; i++)
{
    if (money == phonePrice) break;
    years++;
    if (years % 2 == 0)
    {
   //  even number BD
      if (years == 2)
        {
            money += 10;
            moneyBobi++;
            money--;
        }
        else if (years == 4)
        {
            money += 20;
            moneyBobi++;
            money--;
        }
        else if (years == 6)
        {
            money += 30;
            moneyBobi++;
            money--;
        }
    }
//   odd number BD
    else
    {
        if (years == 1)
        {
       //   money += 1;
        }
        else if (years == 3)
        {
      //    money += 3;
            moneyBobi++;
            money--;
        }
        else if (years == 5)
        {
      //    money += 5;
            moneyBobi++;
            money--;
        }
    }
}
Console.WriteLine(years);
Console.WriteLine(money);
Console.WriteLine(phonePrice);
