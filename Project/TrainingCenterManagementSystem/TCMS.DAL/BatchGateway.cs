using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class BatchGateway
    {
        public List<Batch> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Batches.ToList();
            }
        }
        public int Save(Batch batch)
        {
            using (var context = new TCMSContext())
            {
                context.Batches.Add(batch);
                return context.SaveChanges();
            }
        }
        public int Update(Batch batch)
        {
            using (var context = new TCMSContext())
            {
                context.Batches.Attach(batch);
                context.Entry(batch).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Batch batch)
        {
            using (var context = new TCMSContext())
            {
                context.Batches.Attach(batch);
                context.Batches.Remove(batch);
                return context.SaveChanges();
            }
        }
        public Batch Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Batches.Find(id);
            }
        }
        public Batch SearchName(string name)
        {
            using (var context = new TCMSContext())
            {
                return context.Batches.FirstOrDefault(e => e.Name == name);
            }
        }
    }
}
