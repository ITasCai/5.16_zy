using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._16_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.	某百货商场当日消费积分最高的八名顾客，他们的积分分别是：18，25，7，36，13，2，89和63，编写程序找出最低的积分及它在数组中的原始位置（索引）。

            //int[] arr = { 18,25,7,36,13,2,89,63 };
            //int min = arr[0];
            //int index = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min>arr[i])
            //    {
            //        min = arr[i];
            //        index = i;
            //    }
            //}

            //Console.WriteLine("最小值为：{0},索引位置为：{1}",min,index);
            //Console.ReadKey();

            #endregion
            #region 3.	从键盘输入10个整数存入在一个数组中，计算所有元素之和及平均值，并找出最大值和最小值。

            //int[] num = new int[10];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个数：",i+1);
            //    int shu = Convert.ToInt32(Console.ReadLine());
            //    num[i] = shu;
            //}

            //int max = num[0];
            //int min = num[0];
            //int sum = 0;
            //double avg = 0;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //    if (num[i]>max)
            //    {
            //        max = num[i];
            //    }

            //    if (num[i]<min)
            //    {
            //        min = num[i];
            //    }
            //}
            //avg = sum / num.Length;
            //Console.WriteLine("最大值为：{0},最小值为：{1},和为：{2},平均数为：{3}",max,min,sum,avg);
            //Console.ReadKey();

            #endregion

            #region 4.	已知数组为小学课程:(语文、数学、自然、社会 ),使用foreach循环

            //string[] str = {"语文", "数学","自然","社会"};
            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
            #endregion

            #region 5.	将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|C罗|罗纳尔多|贝克汉姆”。  

            //string s = string.Empty;
            //string[] arr = { "梅西" ," 卡卡" ," C罗" ," 罗纳尔多" ," 贝克汉姆 "};
            //foreach (string item in arr)
            //{

            //    s += item + "|";
            //}
            //s = s.Remove(s.LastIndexOf("|"), 1);

            //Console.WriteLine(s);
            //Console.ReadKey(); 

            #endregion

            #region 6.	声明一个二维数组int[,] arr = { {11,12,13,14}, {21,22,23,24}, {31,32,33,34} }; 要求：使用二重for循环和foreach输出所有元素。 

            // int[,] arr = { { 11, 12, 13, 14 }, { 21, 22, 23, 24 }, { 31, 32, 33, 34 } };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(" "+arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
            #endregion
            #region 7.	已知某商场有三层,每层商家的经营内容也不同， 其中1楼为服装，2楼为鞋帽，3楼为餐饮。下面列出每层商家的名称。

            //string[][] str = new string[3][];
            //str[0] = new string[] { "服装", "耐克", "阿迪达斯", "北极人", "优衣库"};
            //str[1] = new string[] { "鞋帽","安踏","李宁","特步","双星","回力"};
            //str[2] = new string[] { "餐饮","小肥羊","顺丰肥牛","港式餐厅"};

            //foreach (string[] item in str)
            //{

            //    foreach (string item1 in item)
            //    {
            //        Console.Write(" " + item1);
            //    }
            //    Console.WriteLine();
            //}

            //    Console.ReadKey();

            #endregion

            #region 8.	将成绩优异的前10名学生成绩按从小到大顺序输出，前10名学生成绩如下：[88,87,94,95,86,89,91,99,90,85] ，并打印成绩总和以及平均成绩。    要求：使用冒泡排序.

            //int[] score = { 88, 87, 94, 95, 86, 89, 91, 99, 90, 85 };

            //for (int i = 0; i < score.Length; i++)
            //{
            //    for (int j =score.Length-1; j > i; j--)
            //    {
            //        if (score[j]<score[j-1])
            //        {
            //            int temp = score[j];
            //            score[j] = score[j - 1];
            //            score[j - 1] = temp;
            //        }
            //    }
            //}
            //int sum = 0;
            //double avg = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    sum += score[i];

            //    Console.Write(score[i]+"\t");
            //}
            //avg = sum / score.Length;
            //Console.WriteLine("总分为{0},平均分为{1}",sum,avg);

            //Console.ReadKey();

            #endregion

            #region 9.	将成绩优异的前10名学生成绩按从小到大顺序输出，前10名学生成绩如下：[88,87,94,95,86,89,91,99,90,85] ,并将前三名授予”学习标兵”称号。     要求：将前三名学生成绩，存放到另外一个新数组。用于保存档案。请分别用Copy()和CopyTo()实现。


            //int[] arr = { 88, 87, 94, 95, 86, 89, 91, 99, 90, 85 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //int[] arr2 = new int[3];
            // Array.Copy(arr,0,arr2,0,3);



            //foreach (int item in arr2)
            //{
            //    Console.Write(item+"\t");
            //}

            //Console.ReadKey();

            #endregion

            #region 10.	将一个字符串数组元素的顺序进行反转，{“the”,”sky”,”is”,”blue”} {“blue”,”is”,”sky”,”the”}

            //string[] str = { "the", "sky", "is", "blue" };
            //Array.Reverse(str);
            //foreach (string item in str)
            //{
            //    Console.Write(" "+item);
            //}
            //Console.ReadKey();

            #endregion
        }
    }
}
