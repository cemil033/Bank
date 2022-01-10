using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    public class User
    {
        public string name;
        public string surname;
        public Bankcards creditcard;
        public User()
        {
            name = null;
            surname = null;
            creditcard = null;
        }

        public User(string name, string surname, Bankcards creditcard)
        {
            this.name = name;
            this.surname = surname;
            this.creditcard = creditcard;
        }
        public void Showbalace()
        {
            Console.WriteLine($"Your balance: {creditcard.Balance}AZN\n");
        }
    }
}
