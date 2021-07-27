using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarSolution.Ambev
{
    
    public class UnloadingTime
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public UnloadingTime(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }
    public class Question1
    {
        public static bool Execute(IEnumerable<UnloadingTime> unloadingTimes)
        {

            
            return true;
        }
    }
}