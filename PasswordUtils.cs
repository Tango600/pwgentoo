using System;
using System.Collections.Generic;

namespace PasswUtils
{
    public enum PasswordWeakLevel
    {
        NotDefined,
        VeryWeak,
        Weak,
        Sufficient,
        Strength,
        Resistant,
        VeryResistant
    }

    class PasswordUtils
    {
        private static int MaxRepeatsChar = 2;

        public static string GenerateStrongPass(int PassLength = 7, bool UsePunctuation = true, bool UseEntropy = true)
        {
            Random randC = new Random();
            string result = char.ToString((char)randC.Next(65, 90));

            List<char[]> Intrvs = new List<char[]>();

            char[] charr;
            if (UsePunctuation)
            {
                string specChars = @"!#$%&*+-/=?@\^_|~";   //@"!#$%&()*+-/;<=>?@[\]^_{|}~";
                charr = specChars.ToCharArray();
                    
                Intrvs.Add(charr);
            }

            string gl = "AaEeIiOoUu";
            charr = gl.ToCharArray();
            Intrvs.Add(charr);

            string sl = "BbCcDdFfGgHhJjKkLMmNnPpQqRrSsTtVvWwXxYyZz";
            charr = sl.ToCharArray();
            Intrvs.Add(charr);

            string dl = "189647235";
            charr = dl.ToCharArray();
            Intrvs.Add(charr);

            Random randI = new Random();

            while (result.Length < PassLength)
            {
                int rndIndex = randI.Next(Intrvs.Count);
                int charIndex = randC.Next(Intrvs[rndIndex].Length);

                string C = char.ToString(Intrvs[rndIndex][charIndex]);

                if (!result.Contains(C) && (result.Length < 35))
                {
                    result += C;
                }
                else
                    if (!UseEntropy)
                        result += C;

            }
            return result;
        }

        public static PasswordWeakLevel TestPasswordWeak(string password, string login)
        {
            var _res = PasswordWeakLevel.NotDefined;

            if (!IsPasswordLikeLogin(password, login) && !IsQwertyPasswords(password))
            {
                if (password.Length > 5)
                {
                    if (ContainsUpperLetter(password) && ContainsLowerLetter(password)) _res = PasswordWeakLevel.Weak;
                    if (ContainsDigit(password)) _res++;  //Sufficient

                    if (RepeatSigns(password)) _res--;
                    if (IsStriping(password)) _res++;  //Strength

                    if (ContainsPunctuation(password) && ContainsSeparator(password)) _res++; //Resistant
                    if ((_res == PasswordWeakLevel.Resistant) && (password.Length > 15)) _res++;
                }
                else
                    _res = PasswordWeakLevel.VeryWeak;
            }
            return _res;
        }

        private static bool IsQwertyPasswords(string pass)
        {
            var keyboardlist = new List<string>();
            keyboardlist.Add("azer");
            keyboardlist.Add("qwer");
            keyboardlist.Add("asdf");
            keyboardlist.Add("zxcv");
            keyboardlist.Add("1234");

            foreach (string item in keyboardlist)
            {
                if (pass.ToLower().Trim().Contains(item.ToLower()))
                    return true;
            }
            return false;
        }

        private static bool IsPasswordLikeLogin(string pass, string login)
        {
            if (login != string.Empty)
            {
                if (login.ToLower().Trim().Contains(pass.ToLower().Trim()) || pass.ToLower().Trim().Contains(login.ToLower().Trim()))
                {
                    return true;
                }

                string reversed = "";
                char[] passarr = pass.ToCharArray();

                for (int i = pass.Length - 1; i >= 0; i--)
                {
                    reversed = reversed + passarr[i];
                }

                if (reversed.ToLower().Trim().Contains(login.ToLower().Trim()))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool RepeatSigns(string pass)
        {
            char lastchar = (char)0;
            int _rep = 0;
            foreach (char c in pass)
            {
                if (lastchar == c)
                {
                    _rep++;
                    if (_rep > MaxRepeatsChar)
                        return true;
                }
                lastchar = c;
            }
            return false;
        }

        private static bool IsStriping(string pass) // фактор перемеживание букв и символов
        {
            int stripcount = 0;
            char lastchar = (char)0;
            foreach (char c in pass)
            {
                if ((Char.IsLetterOrDigit(c) && ((Char.IsLetter(c) && Char.IsDigit(lastchar)) || (Char.IsDigit(c) && Char.IsLetter(lastchar)))) ||
                   ((Char.IsLetterOrDigit(c) && !Char.IsLetterOrDigit(lastchar)) || ((Char.IsLetterOrDigit(lastchar) && !Char.IsLetterOrDigit(c)))))
                {
                    stripcount++;
                    if (stripcount > pass.Length / 3)
                        return true;
                }
                lastchar = c;
            }
            return false;
        }

        private static bool ContainsLowerLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }

        private static bool ContainsUpperLetter(string pass)
        {
            foreach (char c in pass)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }

        private static bool ContainsDigit(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private static bool ContainsPunctuation(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsPunctuation(c))
                    return true;
            }
            return false;
        }

        private static bool ContainsSeparator(string pass)
        {
            foreach (char c in pass)
            {
                if (Char.IsSeparator(c))
                    return true;
            }
            return false;
        }

        public static bool BadPasswordSecurity(string pass, string Login)
        {
            return ((int)PasswordUtils.TestPasswordWeak(pass, Login) < 5);
        }
    }
}
