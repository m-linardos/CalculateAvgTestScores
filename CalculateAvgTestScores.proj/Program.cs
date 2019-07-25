using System;

namespace CalculateAvgTestScores.proj {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calculate the average of test scores");

            int[] scores = new int[12];
                scores[0] = 71;
                scores[1] = 78;
                scores[2] = 89;
                scores[3] = 73;
                scores[4] = 68;
                scores[5] = 73;
                scores[6] = 96;
                scores[7] = 71;
                scores[8] = 72;
                scores[9] = 65;
                scores[10] = 87;
                scores[11] = 63;

                int total = 0;
                int index = 0;
               // int avg = total / index;

            while (index < 12) {                        // less than the total number
                total = total + scores[index];
                index = index + 1;                      // without this - an infinite loop would be created
                //avg = total / index;
            }
            //int avg = total / index;                // This could cause a problem if another user set the index to 0
            //int avg = total / 12;
            double avg = total / 12.0;              // to get most accurate score, change to decimal
                                 // when changed to a decimal atleast one number in in calculation must be decimal

            //Console.WriteLine("The average test score is " + avg + "%");
            Console.WriteLine($"The average test score is {avg}%");         // another wat to write it




        }
    }
}
