using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class InstructorGateway
    {
        public List<Instructor> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Instructors.ToList();
            }
        }
        public int Save(Instructor instructor)
        {
            using (var context = new TCMSContext())
            {
                context.Instructors.Add(instructor);
                return context.SaveChanges();
            }
        }
        public int Update(Instructor instructor)
        {
            using (var context = new TCMSContext())
            {
                context.Instructors.Attach(instructor);
                context.Entry(instructor).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Instructor instructor)
        {
            using (var context = new TCMSContext())
            {
                context.Instructors.Attach(instructor);
                context.Instructors.Remove(instructor);
                return context.SaveChanges();
            }
        }
        public Instructor Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Instructors.Find(id);
            }
        }
        public Instructor SearchEmail(string email)
        {
            using (var context = new TCMSContext())
            {
                return context.Instructors.FirstOrDefault(e => e.Email == email);
            }
        }
        public Instructor SearchPhone(string phone)
        {
            using (var context = new TCMSContext())
            {
                return context.Instructors.FirstOrDefault(e => e.Phone == phone);
            }
        }
        public Instructor SearchName(string name)
        {
            using (var context = new TCMSContext())
            {
                return context.Instructors.FirstOrDefault(e => e.Name == name);
            }
        }
    }
}
