using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Events.Linq
{
    internal static class Helper

    {
#region void method not parameter
        public static void Success()
        {
            Console.WriteLine("This is Success Message");
        }

        public static void MadeIt()
        {
            Console.WriteLine("WE DID IT!");
        }
        #endregion


#region void method with parameter
        public static void Failed(string message)
        {
            Console.WriteLine($"Unable to process : {message}");
        }
        #endregion


#region Return value methods

        //return true if ch is digit
        public static bool IsDigit(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

        public static bool IsLetter(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch < 'Z');
        }

        #region Any and All methods
        public static bool AnyLetters(List<string> ls)
        {
            for (int i = 0; i < ls.Count; i++)
                foreach (char c in ls[i])
                {
                    if (IsLetter(c))
                        return true;
                }
            return false;
        }

        public static bool AllDigits(List<string> ls)
        {
            for (int i = 0; i < ls.Count; i++)
                foreach (char c in ls[i])
                {
                    if (!IsDigit(c))
                        return false;
                }
            return true;
        }
        #endregion

        #endregion



    }
}
