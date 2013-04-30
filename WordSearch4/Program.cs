﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch4
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamWriter outfile = new StreamWriter(args[1]))
            {
                Stopwatch stopWatch = new Stopwatch();

                double total = 0;
                stopWatch.Start();

                Puzzle puzzle = new Puzzle();
                puzzle.Process(args[0], outfile);

                stopWatch.Stop();

                Console.WriteLine(stopWatch.ElapsedMilliseconds);

                total += stopWatch.ElapsedMilliseconds;

                stopWatch.Reset();

                Console.WriteLine("Avg: " + total / 1000);

                //TimeSpan ts = stopWatch.Elapsed;
                //string elapsedTime = String.Format("Time elapsed in Milliseconds: {0}", ts.TotalMilliseconds);
                //outfile.Write(elapsedTime);
                outfile.Flush();
                //Console.WriteLine("RuntTime " + elapsedTime);
                Console.ReadLine();
            }
        }
    }
}
