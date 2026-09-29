using System;
using System.Data;
using System.IO;
using System.Windows.Markup;
using createTable.cs;

public class PopTableClass
{
    public string[] parseFile(string filePath)
    {
        string [] myValues;

        using(StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                // split the csv file based on commas
                myValues = line.Split(',');
            }
        }

        if(myValues == null || myValues.Length() == 0)
        {
            Console.log("Empty array, csv was not parsed.");
        }

        return myValues;
    }

    public void fillDataTablePantry(string[] myValues)
    {
        int count = 0;

        while(count < myValues.Length())
        {
            for(int i = 0; i < 3; i++)
            {
                DataRow workRow = pantryTable.NewRow();
                workRow[0] = myValues[count];
                count++;
                if(count == myValues.Length())
                {
                    arrayError();
                }
                workRow[1] = myValues[count];
                count++;
                if(count == myValues.Length())
                {
                    arrayError();
                }
                workRow[2] = myValues[count];
                count++;
                if(count == myValues.Length())
                {
                    arrayError();
                }
                pantryTable.Rows.Add(workRow);
            }
        }
    }

    public void arrayError()
    {
        Console.log("Array out of bounds!");
    }
}


