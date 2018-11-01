using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchExercise
{
    abstract class DisplayNums
    {
        public static void DisplayNum(int x)
        {
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
