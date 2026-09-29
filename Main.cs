using System;
using System.Data;
using System.IO;

// dotnet run --project IMS.csproj

namespace IMS
{
    class Program
    {
        static void Main()
        {
            string readNext = "pantryInventory.csv";
            manageTables tables = new manageTables();
            PopTableClass popPantryTable = new PopTableClass(tables.pantryTable);
            string[] indexedItemsArray = popPantryTable.parseFile(readNext);

            // check to see if the file was parsed correctly
            for(int i = 0; i < indexedItemsArray.Length; i++)
            {
                Console.WriteLine(indexedItemsArray[i]);
            }

            popPantryTable.fillDataTablePantry(indexedItemsArray);
        }
    }
}
