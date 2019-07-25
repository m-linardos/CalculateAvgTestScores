using System;

namespace CalculateAvgTestScores.proj {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calculate the average of test scores");

            int[] scores = new int[12]();
                scores[0] = 71;
                scores[1] = 78;
                scores[3] = 89;
                scores[4] = 73;
                scores[5] = 68;
                scores[6] = 73;
                scores[7] = 96;
                scores[8] = 71;
                scores[9] = 72;
                scores[10] = 65;
                scores[11] = 87;
                scores[2] = 63;

                int total = 0;
                int index = 0;
                int avg = total / index;

            while (index < 11) {
                total = total + scores[index];
                index = index + 1;
                //avg = total / index;
            }



            Console.WriteLine("The average test score is " + avg + "%");




        }
    }
}
