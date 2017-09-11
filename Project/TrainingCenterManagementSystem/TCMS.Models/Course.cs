using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Objective { get; set; }
        public double Duration { get; set; }
        public string Prerequisites { get; set; }
        public ICollection<Batch> Batches { get; set; }
    }
}
