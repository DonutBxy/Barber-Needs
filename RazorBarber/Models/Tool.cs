using System;
using System.ComponentModel.DataAnnotations;

namespace RazorTool.Models
{
    public class Tool
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}