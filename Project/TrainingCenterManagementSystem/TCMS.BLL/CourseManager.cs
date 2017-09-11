using System.Collections.Generic;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class CourseManager
    {
        public List<Course> GetAll()
        {
            return new CourseGateway().GetAll();
        }
        public bool Save(Course course)
        {
            return new CourseGateway().Save(course) > 0;
        }
        public bool Update(Course course)
        {
            return new CourseGateway().Update(course) > 0;
        }
        public bool Delete(Course course)
        {
            return new CourseGateway().Delete(course) > 0;
        }
        public Course Search(int id)
        {
            return new CourseGateway().Search(id);
        }
        public Course SearchName(string name)
        {
            return new CourseGateway().SearchName(name);
        }
    }
}
