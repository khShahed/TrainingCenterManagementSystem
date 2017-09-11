using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class TraineeGateway
    {
        public List<Trainee> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Trainees.ToList();
            }
        }
        public int Save(Trainee trainee)
        {
            using (var context = new TCMSContext())
            {
                context.Trainees.Add(trainee);
                return context.SaveChanges();
            }
        }
        public int Update(Trainee trainee)
        {
            using (var context = new TCMSContext())
            {
                context.Trainees.Attach(trainee);
                context.Entry(trainee).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Trainee trainee)
        {
            using (var context = new TCMSContext())
            {
                context.Trainees.Attach(trainee);
                context.Trainees.Remove(trainee);
                return context.SaveChanges();
            }
        }
        public Trainee Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Trainees.Find(id);
            }
        }
        public Trainee SearchEmail(string email)
        {
            using (var context = new TCMSContext())
            {
                return context.Trainees.FirstOrDefault(e => e.Email == email);
            }
        }
        public Trainee SearchPhone(string phone)
        {
            using (var context = new TCMSContext())
            {
                return context.Trainees.FirstOrDefault(e => e.Phone == phone);
            }
        }
    }
}
