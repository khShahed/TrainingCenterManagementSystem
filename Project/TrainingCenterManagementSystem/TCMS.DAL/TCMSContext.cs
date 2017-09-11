using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMS.Models
{
    public class TCMSContext: DbContext
    {
        public TCMSContext():base("TrainingCenterManagementSystemDb")
        {
            
        }

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineeBatch> TraineeBatches { get; set; }
    }
}
