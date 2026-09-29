using System.Data;

DataSet Pantry = new("Pantry");
DataTable pantryTable = Pantry.Tables.Add("pantryTable");

DataColumn pantryID = pantryTable.Columns.Add("Abbreviation", typeof(string));
pantryTable.Columns.Add("Name", typeof(string));
pantryTable.Columns.Add("Quantity", typeof(int));
pantryTable.Columns.Add("Unit", typeof(string));

pantryTable.PrimaryKey = new DataColumn[] { pantryID };

DataSet CleaningSupplies = new("CleaningSupplies");
DataTable cleaningSuppliesTable = CleaningSupplies.Tables.Add("cleaningSuppliesTable");

DataColumn cleaningID = cleaningSuppliesTable.Columns.Add("Abbreviation", typeof(string));
cleaningSuppliesTable.Columns.Add("Name", typeof(string));
cleaningSuppliesTable.Columns.Add("Quantitiy");

cleaningSuppliesTable.PrimaryKey = new DataColumn[] { cleaningID };