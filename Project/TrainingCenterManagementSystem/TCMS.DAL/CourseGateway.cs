using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class CourseGateway
    {
        public List<Course> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Courses.ToList();
            }
        }
        public int Save(Course course)
        {
            using (var context = new TCMSContext())
            {
                context.Courses.Add(course);
                return context.SaveChanges();
            }
        }
        public int Update(Course course)
        {
            using (var context = new TCMSContext())
            {
                context.Courses.Attach(course);
                context.Entry(course).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Course course)
        {
            using (var context = new TCMSContext())
            {
                context.Courses.Attach(course);
                context.Courses.Remove(course);
                return context.SaveChanges();
            }
        }
        public Course Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Courses.Find(id);
            }
        }
        public Course SearchName(string name)
        {
            using (var context = new TCMSContext())
            {
                return context.Courses.FirstOrDefault(e => e.Name == name);
            }
        }
    }
}
