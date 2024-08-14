
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


namespace Delegate.Events.Linq
{
    //Delegate- מצביע לפעולות
            //Action - void delegate
            //Action<type1,type2>
            //Func<return type> - return value delegate
            //Func<In types,return type>
            //Predicate<in Type (single)>


    //Lambda - anonymous delgate---> (in params) =>{code to execute}
    //Linq - Language-Integrated Query
    //event


    #region Declare delegate
    //delegate for void methods
    public delegate void PrintMessageDelegate();
    public delegate void PrintTextMessageDelegate(string m);
    //delegate for return value methods
    public delegate bool CheckDelegate(char c);

    #endregion

    internal class Program
    {
        public static void CheckStrings(List<string> strings, Predicate<List<string>> checkList, Action successCallback, Action<string> failedCallback)
        {
            {
                if (checkList != null && checkList(strings))
                    successCallback?.Invoke();
                else
                    failedCallback?.Invoke("Oi, Oi, Oi");
            }
        }
        public static void Main(string[] args)
        {
            //PrintMessageDelegate print1;
            //print1 = Helper.Success;
            //print1 += Helper.MadeIt;
            //print1?.Invoke();
            //print1 -= Helper.Success;
            //print1?.Invoke();

            //PrintTextMessageDelegate printm = Helper.Failed;
            //if (printm != null)
            //{
            //    printm("Oi, Oi,Oi");
            //}
            // printm?.Invoke("Oi,Oi,OI");

            //CheckDelegate charsCheck = Helper.IsDigit;
            //charsCheck += Helper.IsLetter;
            //Console.WriteLine(charsCheck('8'));

            //Action action1 = Helper.Success;
            //action1?.Invoke();
            //Action<string> action2 = Helper.Failed;
            //action2("Oi,Oi, Oi");

            //Func<char, bool> checkChar = Helper.IsDigit;
            //Console.WriteLine( checkChar('A')); 

            //Predicate<List<string>> checkStrings = Helper.AnyLetters;
            //checkStrings(list);
            //checkStrings=Helper.AllDigits;
            //checkStrings(list);

            List<string> list = new List<string>() { "123", "456", "543", "666" };
            //CheckStrings(list, Helper.AllDigits, Helper.MadeIt, Helper.Failed);
            //CheckStrings(list, Helper.AnyLetters, Helper.Success, Helper.Failed);

            //CheckStrings(list, delegate (List<string> strings) { return strings.Count <0; }, delegate () { Console.WriteLine("Success"); }, delegate (string m) { Console.WriteLine(m); });
            //CheckStrings(list, (strings) => strings.Count <0, () => Console.WriteLine("Success"),  (string m) => Console.WriteLine(m) );

            Console.WriteLine(list.Any((string x) =>
            {
                foreach (char c in x)
                {
                    if (Helper.IsLetter(c)) return true;
                }
                return false;
            }));
            Console.WriteLine(list.All(x => { foreach (char c in x) { if (!Helper.IsDigit(c)) { return false; } } return true; }

            ));

            List<int> ints = new List<int>() { 4, 6, -1, 0, -24, 35 };
            var result = ints.Where(i => i < 0).Where(i=>i>-5).ToList();
           
            
        }



        
    }
}
