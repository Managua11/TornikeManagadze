using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Custom_Data_Pipelines.Program;

namespace Custom_Data_Pipelines
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }
        public decimal? Price { get; set; }
    }
}
