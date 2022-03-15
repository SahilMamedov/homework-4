using System;
using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region refout
            //string str1 = "lorem";
            //Referense(str1);
            //int num = 4;
            //int num2 = num;
            //num2 = 5;
            //Console.WriteLine(num);
            //int num = 5;
            //ChanhgeNum(ref num);
            //Console.WriteLine(num);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, };
            //ChangeIndex(numbers);
            //Console.WriteLine($"outside {numbers[0]}");
            // }
            //static void ChanhgeNum(ref int n)
            //{

            //    n = 10;
            //    Console.WriteLine(n);

            //}
            //static void ChangeIndex(int[] arr)
            //{
            //    arr[0] = 10;
            //    Console.WriteLine($"metohd {arr[0]}");

            //}
            #endregion
            #region stringBuilder
            //string word = "Hello";
            //string word2 = word;
            //word2 = "hi";

            //string word3 = "hi";
            //word3 = "test";
            //Console.WriteLine(word2 == word3);


            //static string  Referense(string str)
            //{
            //    for (int i = str.Length-1; i >= 0; i--)
            //    {

            //        Console.WriteLine(str[i]);
            //    }

            //    return str; 


            //}
            //static StringBuilder ReverseWord(string word)
            //{

            //    StringBuilder newString = new StringBuilder();

            //    for (int i = word.Length-1; i>= 0; i++)
            //    {
            //        newString.Append(word[i]);
            //    }
            //    return newString;

            //}
            #endregion

            #region stringMethods
           // string word2 = "lorem";
          //  string word = "loremolo";



            //equals -deyerleri yoxlayir

            //System.Console.WriteLine(word.ToLower().Equals(word2.ToLower()));
            //Console.WriteLine(word.ToUpper());
            // Console.WriteLine(word.ToLower());

           // string word3 = "  test";
            //trim evelde ve sonda bowluqlari leqv edir
            //Console.WriteLine(word3.Trim())
            //Console.WriteLine(word3.TrimStart());
            //Console.WriteLine(word3.TrimEnd());
            // Console.WriteLine(word3.Replace("t", "g").ToUpper());
            // String.Concat(word, word3).Trim();
            // Console.WriteLine(String.Concat(word, word3).Trim().ToUpper());
            // Console.WriteLine(word.IndexOf("l"));
            //Console.WriteLine(word.LastIndexOf("lo"));
           // string word4 = " ";
            //string word5 = "";
            //Console.WriteLine(string.IsNullOrEmpty(word5));
            //Console.WriteLine(String.IsNullOrWhiteSpace(word5));



           // string[] names = { "lorem", "ipsum" };

            //String.Join - arr ceviri stringe 

            // string str =  String.Join(" ", names);
            //Console.WriteLine(str);

            //Split - str ceviri arr
           // string str = "hello how are you";
           // string[] newArray = str.Split("o");
           // for (int i = 0; i < newArray.Length; i++)
           // {
                //Console.WriteLine($" {i}:  {newArray[i]}");
            //}

            //int[] numbers = { 1, -23, 123, 122, 33, 2, 1 };
            //Array.Sort(numbers);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Resize(ref numbers, 5);


            #endregion
        }
    }



}     
