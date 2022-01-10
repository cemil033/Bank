using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    public class Bank
    {
        public List<User> users;
        public Bank()
        {
            users = new();
        }

        public Bank(List<User> users)
        {
            this.users = users;
        }
        public void Adduser()
        {
            string Bankname;
            string Fullname;
            string Pan=null;
            string Pin=null;
            string CVC=null;
            string ExpireDate;
            double Balance;
            string name;
            string surname;
            Console.WriteLine("Bankin adini daxil edin.");
            Bankname = Console.ReadLine();
            Console.WriteLine("Adinizi daxil edin");
            name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin");
            surname = Console.ReadLine();
            Fullname = name + " " + surname;
            Console.WriteLine("Balansinizi daxil edin");
            Balance = double.Parse(Console.ReadLine());
            DateTime lastYear = DateTime.Today.AddYears(+1);
            ExpireDate = lastYear.ToString();
            while (Pan==null){
                Pan = Gener.Randm(16);
                foreach (var item in users){
                    if (Pan == item.creditcard.Pan)
                    {
                        Pan = null;
                        break;
                    }
                    Gener.Rand = "";
               }
            }
            while (Pin == null)
            {
                Pin = Gener.Randm(4);
                foreach (var item in users)
                {
                    if (Pin == item.creditcard.Pin)
                    {
                        Pin = null;
                        break;
                    }
                }
                Gener.Rand = "";
            }
            while (CVC == null)
            {
                CVC = Gener.Randm(3);
                foreach (var item in users)
                {
                    if (CVC == item.creditcard.CVC)
                    {
                        CVC = null;
                        break;
                    }
                }
                Gener.Rand = "";
            }
        }
        public void Adduser(string Bankname, string name,string surname, double Balance)
        {
            string Fullname;
            string Pan = null;
            string Pin = null;
            string CVC = null;
            string ExpireDate;
            Fullname = name + " " + surname;
            DateTime lastYear = DateTime.Today.AddYears(+1);
            ExpireDate = lastYear.ToString();
            while (Pan == null)
            {
                Pan = Gener.Randm(16);
                foreach (var item in users)
                {
                    if (Pan == item.creditcard.Pan)
                    {
                        Pan = null;
                        break;
                    }
                }
                Gener.Rand = "";
            }
            while (Pin == null)
            {
                Pin = Gener.Randm(4);
                foreach (var item in users)
                {
                    if (Pin == item.creditcard.Pin)
                    {
                        Pin = null;
                        break;
                    }
                }
                Gener.Rand = "";
            }
            while (CVC == null)
            {
                CVC = Gener.Randm(3);
                foreach (var item in users)
                {
                    if (CVC == item.creditcard.CVC)
                    {
                        CVC = null;
                        break;
                    }
                }
                Gener.Rand = "";
            }
            users.Add(new User(name, surname, new Bankcards(Bankname, Fullname, Pan, Pin, CVC, ExpireDate, Balance)));
        }
    }
}
