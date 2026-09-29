using System.Data;

namespace IMS
{
    public class manageTables
    {
        public DataSet Pantry = new("Pantry");
        public DataTable pantryTable;
        public DataSet CleaningSupplies = new("CleaningSupplies");
        public DataTable cleaningSuppliesTable;

        public manageTables()
        {
            pantryTable = Pantry.Tables.Add("pantryTable");
            cleaningSuppliesTable = CleaningSupplies.Tables.Add("cleaningSuppliesTable");

            DataColumn pantryID = pantryTable.Columns.Add("Abbreviation", typeof(string));
            pantryTable.Columns.Add("Name", typeof(string));
            pantryTable.Columns.Add("Quantity", typeof(int));
            pantryTable.Columns.Add("Unit", typeof(string));

            pantryTable.PrimaryKey = new DataColumn[] { pantryID };

            DataColumn cleaningID = cleaningSuppliesTable.Columns.Add("Abbreviation", typeof(string));
            cleaningSuppliesTable.Columns.Add("Name", typeof(string));
            cleaningSuppliesTable.Columns.Add("Quantity");

            cleaningSuppliesTable.PrimaryKey = new DataColumn[] { cleaningID };
        }
    }   
}
