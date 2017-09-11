using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMS.Models
{
    public class TraineeBatch
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public int Fee { get; set; }
        [ForeignKey("Batch")]
        public int BatchId { get; set; }
        public virtual Batch Batch { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
