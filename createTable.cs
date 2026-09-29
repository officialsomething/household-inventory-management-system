using System.Data;

class manageTables
{
    public DataSet Pantry = new("Pantry");
    public DataTable pantryTable = Pantry.Tables.Add("pantryTable");
    public DataSet CleaningSupplies = new("CleaningSupplies");
    public DataTable cleaningSuppliesTable = CleaningSupplies.Tables.Add("cleaningSuppliesTable");

    public manageTables()
    {        
        DataColumn pantryID = pantryTable.Columns.Add("Abbreviation", typeof(string));
        pantryTable.Columns.Add("Name", typeof(string));
        pantryTable.Columns.Add("Quantity", typeof(int));
        pantryTable.Columns.Add("Unit", typeof(string));

        pantryTable.PrimaryKey = new DataColumn[] { pantryID };

        DataColumn cleaningID = cleaningSuppliesTable.Columns.Add("Abbreviation", typeof(string));
        cleaningSuppliesTable.Columns.Add("Name", typeof(string));
        cleaningSuppliesTable.Columns.Add("Quantitiy");

        cleaningSuppliesTable.PrimaryKey = new DataColumn[] { cleaningID };
    }
}
