using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore
{
    public class BookRecord
    {
        public int ItemID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublicationsName {  get; set; }
        public int   Quantity { get; set; }
        public decimal Price { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Created { get; set; }
        
    }
}
