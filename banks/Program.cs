using System;
using banks;

Bank ATM = new();
ATM.Adduser("RabiteBank", "Cemil", "Ibrahimov", 950.5);
ATM.Adduser("RabiteBank", "Ceyhun", "Ibrahimov", 355.5);
ATM.Adduser("RabiteBank", "Ilqar", "Eliyev", 620.3);
ATM.Adduser("RabiteBank", "Reshad", "Resulov", 425.55);
ATM.Adduser("RabiteBank", "Nicaq", "Qafurzade", 60.5);
string cpin = ATM.users[0].creditcard.Pin;
string cpan = ATM.users[0].creditcard.Pan;
string npin = ATM.users[4].creditcard.Pin;
string npan = ATM.users[4].creditcard.Pan;
Console.WriteLine("Bunlari qeyd edin silinecek");
Console.WriteLine($"Cemil pin: {cpin}");
Console.WriteLine($"Cemil pan: {cpan}");
Console.WriteLine($"Nicat pin: {npin}");
Console.WriteLine($"Nicat pin: {npan}");
Console.ReadLine();
string pan;
string pin;
int chs1;
int chs2;
int reg=0;
int reg1=0;
double cash;
while (true)
{
    try {
        Console.WriteLine("Welcome");
        Console.WriteLine("Enter your pin");
        pin = Console.ReadLine();
        foreach (var item in ATM.users)
    {
        if (pin == item.creditcard.Pin)
        {
            reg++;
        }
    }
        if (reg == 0)
        {
        throw new ArgumentException("Try again");
        }
        foreach (var item in ATM.users){
             if (pin == item.creditcard.Pin){
                 while (true){
                     Console.Clear();
                     Console.WriteLine("1.Balance");
                     Console.WriteLine("2.Cash");
                     Console.WriteLine("3.Card to Card money transfer");
                     Console.WriteLine("0.Quit");
                     chs1 = int.Parse(Console.ReadLine());

                     if (chs1 == 1)
                {
                    Console.Clear();
                    item.Showbalace();
                    Console.WriteLine("Geri qayidmaq ucun enteri sixin");
                    Console.ReadLine();
                }

                     else if (chs1 == 2)
                {
                    while (true)
                    {
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("1. 10 AZN");
                            Console.WriteLine("2. 20 AZN");
                            Console.WriteLine("3. 50 AZN");
                            Console.WriteLine("4. 100 AZN");
                            Console.WriteLine("5. Other");
                            Console.WriteLine("0. Back");

                            chs2 = int.Parse(Console.ReadLine());

                            if (chs2 == 1)
                            {
                                if (item.creditcard.Balance < 10)
                                {
                                    throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                }
                                item.creditcard.Balance -= 10;
                                    Console.WriteLine("Emeliyyat ugurlu oldu");
                                    Console.ReadLine();
                                }

                            else if (chs2 == 2)
                            {
                                if (item.creditcard.Balance < 20)
                                {
                                    throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                }
                                item.creditcard.Balance -= 20;
                                    Console.WriteLine("Emeliyyat ugurlu oldu");
                                    Console.ReadLine();
                                }

                            else if (chs2 == 3)
                            {
                                if (item.creditcard.Balance < 50)
                                {
                                    throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                }
                                item.creditcard.Balance -= 50;
                                    Console.WriteLine("Emeliyyat ugurlu oldu");
                                    Console.ReadLine();
                                }

                            else if (chs2 == 4)
                            {
                                if (item.creditcard.Balance < 100)
                                {
                                    throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                }
                                item.creditcard.Balance -= 100;
                                    Console.WriteLine("Emeliyyat ugurlu oldu");
                                    Console.ReadLine();
                            }

                            else if (chs2 == 5)
                            {
                                cash = double.Parse(Console.ReadLine());
                                if (cash > item.creditcard.Balance)
                                {
                                    cash = 0;
                                    throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                }
                                item.creditcard.Balance -= cash;
                                Console.WriteLine("Emeliyyat Ugurlu oldu");
                                    Console.ReadLine();
                            }

                            else break;

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadLine();
                        }


                    }
                }

                     else if (chs1 == 3)
                     {
                         cash = 0;
                         while (cash == 0)
                         {
                             try
                             {
                                 Console.Clear();
                                 Console.WriteLine("Gondermek istediyiniz hesabin PAN kodunu daxil edin.");
                                 pan = Console.ReadLine();
                                 foreach (var item1 in ATM.users)
                                 {
                                     if (pan == item1.creditcard.Pan)
                                     {
                                         reg1++;
                                     }
                                 }
                                 if (reg1 == 0)
                                 {
                                     throw new ArgumentException("Try again");
                                 }
                                 foreach (var item2 in ATM.users)
                                 {
                                     if (pan == item2.creditcard.Pan)
                                     {
                                         item.Showbalace();
                                         Console.WriteLine($"Gondermek istediyiniz hesab: {item2.creditcard.Fullname}");
                                         Console.WriteLine("Meblegi daxil edin.");
                                         cash = double.Parse(Console.ReadLine());
                                         if (cash > item.creditcard.Balance)
                                         {
                                             throw new ArgumentOutOfRangeException("Balansda yeteri qeder mebleg yoxdur");
                                         }
                                         item.creditcard.Balance -= cash;
                                         item2.creditcard.Balance += cash;
                                         Console.WriteLine("Emeliyyat ugurlu oldu.Esas menyuya qayitmaq ucun Enter sixin");
                                         if (Console.ReadLine() == null) { break; }
                                     }
                                 }

                             }
                             catch (Exception ex)
                             {

                                 Console.WriteLine(ex.Message);
                                 Console.ReadLine();
                            }

                         }
                     }
                     else break;
                 }
        }
    }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }

}
