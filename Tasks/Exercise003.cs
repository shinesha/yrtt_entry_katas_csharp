using System;
using System.Collections.Generic;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.

namespace TechReturners.Tasks
{
    public class Exercise003
    {
        public static int[] RowWeights(int[] a)
        {
            int sum1= 0;
            int sum2 = 0;
            int[] output = new int[2];
            var teamOne = new List<int>{};
            var teamTwo = new List<int>{};

            for(int i=0,j=0; i<a.Length; i+=2 ,j++)
                sum1 = sum1 + a[i];
            
            output[0] = sum1;

            for(int i=1,j=0;i<a.Length; i+=2 ,j++)
                sum2 = sum2 + a[i];
            
            output[1]= sum2;

            return output;
            throw new NotImplementedException();
        }
    }
}

