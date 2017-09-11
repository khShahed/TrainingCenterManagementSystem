using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class TraineeBatchGateway
    {
        public List<TraineeBatch> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.TraineeBatches.ToList();
            }
        }
        public int Save(TraineeBatch traineeBatch)
        {
            using (var context = new TCMSContext())
            {
                context.TraineeBatches.Add(traineeBatch);
                return context.SaveChanges();
            }
        }
        public int Update(TraineeBatch traineeBatch)
        {
            using (var context = new TCMSContext())
            {
                context.TraineeBatches.Attach(traineeBatch);
                context.Entry(traineeBatch).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(TraineeBatch traineeBatch)
        {
            using (var context = new TCMSContext())
            {
                context.TraineeBatches.Attach(traineeBatch);
                context.TraineeBatches.Remove(traineeBatch);
                return context.SaveChanges();
            }
        }
        public TraineeBatch Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.TraineeBatches.Find(id);
            }
        }
    }
}
