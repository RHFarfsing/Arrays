using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[]
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var sum = 0;
            foreach (var nbr in numbers) {
                if (nbr % 3 == 0 || nbr% 5 ==0) {
                    continue;
                    }
                sum += nbr * 3;
                }
            Console.WriteLine($"Total is {sum}");
            }
        }//class===========================================================================================================================================================
    }
