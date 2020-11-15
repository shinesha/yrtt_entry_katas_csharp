using System;

// The clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
// Your task is to make the 'past' function return the time converted to milliseconds.
// More examples in the test cases below.

namespace TechReturners.Tasks
{
    public class Exercise002
    {
        public static int Past(int h, int m, int s)
        {
            int sumH = h*60*60*1000;
            int sumM = m*60*1000;
            int sumS = s*1000;

        return sumH+sumM+sumS; 

            throw new NotImplementedException();
        }
    }
}

