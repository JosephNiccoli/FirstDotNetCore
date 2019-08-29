using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Movie
    {
        public int Id { get; set; } // for the primary key

        public string Title { get; set; }

        [DataType(DataType.Date)] // specifies the type of data associated with the property  // DataAnnotations 
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }


    }
}
