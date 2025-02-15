using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BooksStore
{
 
    public class CSVHelper
    {
        /// <summary>
        /// Writes a collection of data to a CSV file.
        /// </summary>
        /// <typeparam name="T">The type of data in the collection.</typeparam>
        /// <param name="filePath">The file path to save the CSV file.</param>
        /// <param name="data">The collection of data to write to the CSV.</param>
        /// <param name="headers">Optional headers for the CSV file.</param>
        public static void WriteToCsv<T> (string filePath, IEnumerable<T> data, string[] headers = null)
        {
            StringBuilder csvContent = new StringBuilder();

            bool fileExists = File.Exists(filePath);

            // Add headers if provided
            if (!fileExists && headers != null)
            {
                csvContent.AppendLine(string.Join(",", headers));
            }

            // Add rows of data
            foreach (var item in data)
            {
                var values = item.GetType().GetProperties();
                var row = new List<string>();

                foreach (var value in values)
                {
                    row.Add(value.GetValue(item)?.ToString() ?? string.Empty);
                }

                csvContent.AppendLine(string.Join(",", row));
            }

            // Write or append to file
            if (fileExists)
            {
                File.AppendAllText(filePath, csvContent.ToString());
            }
            else
            {
                File.WriteAllText(filePath, csvContent.ToString());
            }
        }
    }

}
