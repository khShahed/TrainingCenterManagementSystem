using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMS.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public ICollection<Batch> Batches { get; set; }
    }
}
