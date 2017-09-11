using System.Collections.Generic;

namespace TCMS.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public int Capacity { get; set; }
        public ICollection<Batch> Batches { get; set; }
    }
}
