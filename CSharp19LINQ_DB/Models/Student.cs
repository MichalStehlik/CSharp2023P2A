using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp19LINQ_DB.Models
{
    internal class Student
    {
        // StudentId
        public int Id { get; set; }
        /*
         * [Key]
         * public int BakalariKod {get; set;}
         */
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
    }
}
