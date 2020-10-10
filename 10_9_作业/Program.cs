using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_9_作业
{
    delegate void D(int[] A);//声明委托
    class Program
    {
        public static void DisplayArray(int[] A)//打印数组
        {
            foreach (var item in A)
            {
                Console.Write("{0,5}", item);
            }
            Console.WriteLine();
        }
        //调用排序算法
        public static void SortArray(int[] A,string information, D sort)
        {
            sort(A);//调用排序算法
            Console.Write(information+"\t");//输出显示提示
            DisplayArray(A);//显示数组
        }
        //冒泡算法->升序
        public static void SortA(int[] A)
        {
            int i, t;
            int N = A.Length;//获取数组的长度
            for (int loop = 0; loop <= N-1; loop++)//外循环比较
            {
                for (i = 0; i < N - 1-loop; i++)//内循环比较
                {
                    if (A[i] > A[i+1])//相邻两数交换
                    {
                        t = A[i]; //中间值
                        A[i] = A[i + 1];
                        A[i + 1] = t;
                    }
                }
            }
        }
        //冒泡算法->降序
        public static void SortB(int[] A)
        {
            int i, t;
            int N = A.Length;//获取数组的长度
            for (int loop = 0; loop <= N - 1; loop++)//外循环比较
            {
                for (i = 0; i < N - 1 - loop; i++)//内循环比较
                {
                    if (A[i] < A[i + 1])//相邻两数交换
                    {
                        t = A[i]; //中间值
                        A[i] = A[i + 1];
                        A[i + 1] = t;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] A = new int[10];Random rd = new Random();

            //数组A赋值(0~100之间的随机数)
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rd.Next(0, 100);
            }

            Console.Write("原始数组:\t");
            DisplayArray(A);

            SortArray(A, "升序排序数组:", SortA);
            SortArray(A, "降序排序数组:", SortB);

            Console.ReadKey();
        }
    }
}
