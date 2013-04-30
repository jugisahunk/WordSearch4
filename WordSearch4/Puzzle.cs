using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordSearch4
{
    internal class Puzzle
    {
        int RowCount, ColumnCount;
        List<string> inputRows = new List<string>(), inputWords = new List<string>();

        internal void Process (string inputDataFilePath, StreamWriter outFile){

            ReadInData(inputDataFilePath);

            inputWords.Sort(new DescendingComparer());

            ColumnCount = inputRows[0].Length;
            RowCount = inputRows.Count();
        }

        internal void ReadInData(string filePath)
        {
            List<string> inputRows = new List<string>();
            bool readingRows=false, readingWords=false, addLine;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    addLine = true;

                    if (line.IndexOf("***Puzzle") > -1)
                    {
                        readingRows = true;
                        addLine = false;
                    }
                    else if (line.IndexOf("**Puzzle") > -1)
                    {
                        readingRows = false;
                        addLine = false;
                    }
                    else if (line.IndexOf("***Word List") > -1)
                    {
                        readingWords = true;
                        addLine = false;
                    }
                    else if (line.IndexOf("**Word List") > -1)
                    {
                        readingWords = false;
                        addLine = false;
                    }

                    if (readingRows && addLine)
                        inputRows.Add(line);
                    else if (readingWords && addLine)
                        inputWords.Add(line);
                }
            }
        }
    }
}