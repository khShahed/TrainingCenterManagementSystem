using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMS.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<TraineeBatch> TraineeBatches { get; set; }
    }
}
