using GroupWork.Helper;
using System.Dynamic;
namespace GroupWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Helper.Helper.GetPolidrom();
            //Helper.Helper.SezarFoward();
            //Helper.Helper.SezarBack();
            //Helper.Helper.SumList();
            //Helper.Helper.Sum15();
            //Helper.Helper.Binary();
            //Helper.Helper.Anaqram();
            //Helper.Helper.Factorial();
            Helper.Helper.Difference([1,2,3]);
            Helper.Helper.IsOdd();
            Helper.Helper.CustomSum();
            Helper.Helper.EvenOddDifference([1,2,3,4]);
            //5)Sozlerin ardicilligini res et.

            string cumle = "Salam dunya";
            string ters = Ters(cumle);

            Console.WriteLine(ters);

        }
        static string Ters(string cumle)
        {


            char[] chars = new char[cumle.Length];

            for (int i = cumle.Length - 1, j = 0; i >= 0; i--, j++)
            {
                chars[j] = cumle[i];
            }

            return new string(chars);
        }


    }
    
}
