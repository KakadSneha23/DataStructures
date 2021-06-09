using System;

namespace SubsequnceString
{
    class SubsequnceStringRemoval
    {
        static void Main(string[] args)
        {
            int count = 0;
            //string str = "baabc";
            string str = Console.ReadLine();
            string str1 = str;
            while (str1 != "")
            {
                if(checkPalindrome(str1))
                {
                    Console.WriteLine("palindrome");
                    count++;
                    str = str.Remove(0, str1.Length);
                    str1 = str;
                }
                else
                {
                    Console.WriteLine("not palindrome");
                    str1 = newstring(str1);
                    Console.WriteLine(str1);
                }
            }
            Console.WriteLine("\n\nCount : " + count);
        }
        public static bool checkPalindrome(string str)
        {
            string str1 = str;
            int p = 0;
            for(int i=str.Length-1;i>=0;i--)
            {
                if(str[p]!=str1[i])
                {
                    return false;
                }
                p++;
            }
            return true;
        }
        public static string newstring(string str)
        {
            string str1;
            str1 = str.Substring(0,str.Length-1);
            return str1;
        }
       
    }
}
