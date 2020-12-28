using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter_Takip
{
    class RNGCrypt
    {
        public string UnHashPassword(Envanter_Database.KULLANICI user)
        {
            if (user != null)
            {
                string password = user.Sifre.Substring(2, 2) + user.Sifre.Substring(7, 2) + user.Sifre.Substring(11, 2) + user.Sifre.Substring(17, user.Sifre.Length - 17);
                return password;
            }
            return user.Sifre;
        }
        public string HashPassword(Envanter_Database.KULLANICI user)
        {

            if (user == null)
            {
                return user.Sifre;
            }
            Random rnd = new Random();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwe'!^+%&/()=?~rtyuıopğüasdfghjklşi,<zxcvbnmöç.1234567890".ToCharArray();
            string password = alpha[rnd.Next(0, alpha.Length - 1)].ToString();
            password = password + alpha[rnd.Next(0, alpha.Length - 1)];
            password = password + user.Sifre.Substring(0, 2) + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] +
               user.Sifre.Substring(2, 2) + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] +
               user.Sifre.Substring(4, 2) + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] + alpha[rnd.Next(0, alpha.Length - 1)] +
               user.Sifre.Substring(6, user.Sifre.Length - 6);
            return password;


        }
    }
}
