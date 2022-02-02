using first_mvc_project.Models;
using System.Data;

namespace first_mvc_project.Classes
{
    public class DataAccess
    {
        public static ViewData getViewData()
        {
            // Create variables in Index() function
            Random rnd = new Random();
            var firstList = new List<string>();
            int num = rnd.Next(0, 10);
            DataSet firstDataset = new DataSet();


            // Create table
            firstDataset.Tables.Add("People");

            // Create columns name & ranNum
            firstDataset.Tables[0].Columns.Add("Id", typeof(int));
            firstDataset.Tables[0].Columns.Add("Name", typeof(string));
            firstDataset.Tables[0].Columns.Add("Random", typeof(int));


            // Declaration of ViewData
            var ViewData = new ViewData();


            // Insert rows in columns
            for (int i = 1; i < rnd.Next(4, 11); i++)
            {
                firstDataset.Tables[0].Rows.Add(i, "Navn", rnd.Next(0, 10));
            }
            // Insert new Name into List of Names in ViewData
            for (int tableIndex = 0; tableIndex < firstDataset.Tables.Count; tableIndex++)
            {
                for (int rowIndex = 0; rowIndex < firstDataset.Tables[tableIndex].Rows.Count; rowIndex++)
                {
                    var tempNames = new Name();
                    tempNames.Id = int.Parse(firstDataset.Tables[tableIndex].Rows[rowIndex]["Id"].ToString());
                    tempNames.Title = firstDataset.Tables[tableIndex].Rows[rowIndex]["Name"].ToString();
                    tempNames.Random = int.Parse(firstDataset.Tables[tableIndex].Rows[rowIndex]["Random"].ToString());
                    // Add List of Names with random integeres into List in ViewData Model
                    ViewData.Names.Add(tempNames);
                }
            }

            return ViewData;
        }
    }
}
