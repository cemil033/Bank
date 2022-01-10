

namespace banks
{
    public class Bankcards
    {
        public string Bankname;
        public string Fullname;
        public string Pan;
        public string Pin;
        public string CVC;
        public string ExpireDate;
        public double Balance;

        public Bankcards(string bankname, string fullname, string pan, string pin, string cVC, string expireDate, double balance)
        {
            Bankname = bankname;
            Fullname = fullname;
            Pan = pan;
            Pin = pin;
            CVC = cVC;
            ExpireDate = expireDate;
            Balance = balance;
        }
    }
}
