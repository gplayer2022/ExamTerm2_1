using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTerm2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Question01();
            Program.Question02();
            Program.Question03();
            Program.Question04();
            Program.Question05();
            Program.Question06();
            Program.Question07();
            Program.Question08();
            Program.Question09();
            Program.Question10();
        }

        /// <summary>
        /// 問 1
        /// </summary>
        private static void Question01()
        {
            Console.WriteLine("   |  1   2   3   4   5   6   7   8   9");
            Console.WriteLine("---|--------------------------------------");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(" {0} |", i);
                for (int j = 1; j < 10; j++)
                {
                    int answer = i * j;
                    if (answer < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" {0} ", answer);
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// 問 2
        /// </summary>
        private static void Question02()
        {

        }

        /// <summary>
        /// 問 3
        /// </summary>
        private static void Question03()
        {

        }

        /// <summary>
        /// 問 4
        /// </summary>
        private static void Question04()
        {

        }

        /// <summary>
        /// 問 5
        /// </summary>
        private static void Question05()
        {

        }

        /// <summary>
        /// 問 6
        /// </summary>
        private static void Question06()
        {
            
        }

        /// <summary>
        /// 問 7
        /// </summary>
        private static void Question07()
        {

        }

        /// <summary>
        /// 問 8
        /// </summary>
        private static void Question08()
        {

        }

        /// <summary>
        /// 問 9
        /// </summary>
        private static void Question09()
        {

        }

        /// <summary>
        /// 問 10
        /// </summary>
        private static void Question10()
        {

        }
    }
}
