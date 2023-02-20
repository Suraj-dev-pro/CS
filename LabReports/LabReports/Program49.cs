//C# linq query
using System;
using System.Collections.Generic;
using System.Linq;

class Program49
{
    static void Main()
    {
        //specify the data source
        int[] scores = new int[] { 97, 98, 99, 60, 81 };
        //define the query expression
        IEnumerable<int> ScoreQuery = from score in scores
                                      where score > 80
                                      select score;
        //execute query
        foreach(int i in ScoreQuery)
        {
            Console.WriteLine(i + " ");
        }
    }
}