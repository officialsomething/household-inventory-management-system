using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace IMS
{
    public class PopTableClass
    {
        private readonly DataTable pantryTable;

        public PopTableClass(DataTable pantryTable)
        {
            this.pantryTable = pantryTable;
        }

        public string[] parseFile(string filePath)
        {
            List<string> myValues = new List<string>();

            using(StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    // split the csv file based on commas
                    myValues.AddRange(line.Split(','));
                }
            }

            if(myValues.Count == 0)
            {
                Console.WriteLine("Empty array, csv was not parsed.");
            }

            return myValues.ToArray();
        }

        public void fillDataTablePantry(string[] myValues)
        {
            // each row uses 4 values from the array; the first 4 are the csv header
            for(int count = 4; count < myValues.Length; count += 4)
            {
                if(count + 3 >= myValues.Length)
                {
                    arrayError();
                    return;
                }

                DataRow workRow = pantryTable.NewRow();
                workRow[0] = myValues[count];
                workRow[1] = myValues[count + 1];
                workRow[2] = myValues[count + 2];
                workRow[3] = myValues[count + 3];
                pantryTable.Rows.Add(workRow);
            }
        }

        public void arrayError()
        {
            Console.WriteLine("Array out of bounds!");
        }
    }
}
