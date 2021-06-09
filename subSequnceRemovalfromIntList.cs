using System;
using System.Collections.Generic;

namespace subSequnceRemovalIntList
{
    class subSequnceRemovalfromIntList
    {
        static void Main(string[] args)
        {
            List<int> sequnece = new List<int> { 1,2,3,1,1,4,3};
            List<int> removedSeq = removeSequnce(sequnece);
            Console.WriteLine("removedSeq");
            display(removedSeq);
            Console.WriteLine();
        }
        public static List<int> removeSequnce(List<int> s1)
        {
            List<int> common = new List<int>();
            List<int> distinct = new List<int>();
            if(checkDistinct(s1))
            {
                common.Add(-1);
                return common;
            }
            else
            {
                for(int i=0;i<s1.Count;i++)
                {
                    int flag = 1;
                    for (int j = 0; j < s1.Count; j++)
                    {
                        Console.WriteLine("s1[i] : {0} --- s1[j] : {1} ",s1[i],s1[j]);
                        if (j == i)
                            continue;
                        if (s1[i] == s1[j])
                        {
                            common.Add(s1[i]);
                            flag = 0;
                            break;
                        }   
                    }
                    Console.WriteLine("flag :  {0}", flag);
                    if (flag == 1)
                        distinct.Add(s1[i]);
                }

                int k = 0;
                while(k<common.Count)
                {
                    Console.Write("distinct : ");
                    display(distinct);
                    Console.WriteLine();


                    Console.Write("common : ");
                    display(common);
                    Console.WriteLine();


                    distinct.Add(common[k]);
                    
                    if (checkDistinct(distinct))
                    {
                        List<int> ascen = common;
                        ascen.RemoveAt(k);

                        Console.Write("ascending : ");
                        display(ascen);
                        Console.WriteLine();

                        if (checkAscending(ascen))
                        {
                            common = ascen;
                        }
                        else
                        {
                            distinct.Remove(common[k]);
                            k++;
                        }
                    }
                    else
                    {
                        distinct.RemoveAt(distinct.Count-1);
                        k++;
                    }                    
                }

            }



            return common;
        }
        public static bool checkDistinct(List<int> s1)
        {
            foreach(int i in s1)
            {
                for(int j=i+1;j<s1.Count;j++)
                {
                    if (s1[i] == s1[j])
                        return false;
                }
            }
            return true;
        }
        public static bool checkAscending(List<int> s1)
        {
            foreach (int i in s1)
            {
                for (int j = i + 1; j < s1.Count; j++)
                {
                    if (s1[i] > s1[j])
                        return false;
                }
            }
            return true;
        }
        public static void display(List<int> s1)
        {
            Console.Write("{ ");
            foreach (int i in s1)
                Console.Write(i +", ");
            Console.Write("} ");
        }
    }
}