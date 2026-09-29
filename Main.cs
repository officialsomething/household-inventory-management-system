using populateTable.cs;

class Program
{
    static void Main()
    {
        string readNext = "pantryInventory.csv";
        PopTableClass popPantryTable = new PopTableClass();
        string[] indexedItemsArray = popPantryTable.parseFile(readNext);
        popPantryTable.fillDataTablePantry(indexedItemsArray);
    }
}