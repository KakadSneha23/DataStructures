using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int max=-100;
        int sum=0;
        
        for(int k=0;k<4;k++)
        {
            for(int i=0;i<4;i++)
            {
                sum=0;
                for(int j=i;j<i+3;j++)
                {
                    sum = sum + arr[k][j];
                }
                sum = sum + arr[k+1][i+1];
                for(int j=i;j<i+3;j++)
                {
                    sum = sum + arr[k+2][j];
                }
                if(sum>max)
                    max = sum;
                //Console.WriteLine("sum : {0} , max : {1}",sum,max);    
            }
        }
        return max;
    }

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);

    }
}
