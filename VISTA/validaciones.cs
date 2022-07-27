using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA
{
    internal class validaciones
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsValidPassword(string password)
        {
            bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidUser(string user) {
            bool mayuscula = false, minuscula = false;
            for (int i = 0; i < user.Length; i++)
            {
                if (Char.IsUpper(user, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(user, i))
                {
                    minuscula = true;
                }
            }
            if (mayuscula && minuscula && user.Length >= 4)
            {
                return true;
            }
            return false;
        }
    }
}
