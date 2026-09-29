using System.Data;

DataSet Pantry = new("Pantry");

DataTable pantryTable = Pantry.Tables.Add("Ingredients");

DataColumn pantryID = pantryTable.Columns.Add("Abbreviation", typeof(string));
pantryTable.Columns.Add("Name", typeof(string));
pantryTable.Columns.Add("Quantity", typeof(int));

pantryTable.PrimaryKey = new DataColumn[] { pantryID };

