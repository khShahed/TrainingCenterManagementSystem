using System.Collections.Generic;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class InstructorManager
    {
        public List<Instructor> GetAll()
        {
            return new InstructorGateway().GetAll();
        }
        public bool Save(Instructor instructor)
        {
            return new InstructorGateway().Save(instructor) > 0;
        }
        public bool Update(Instructor instructor)
        {
            return new InstructorGateway().Update(instructor) > 0;
        }
        public bool Delete(Instructor instructor)
        {
            return new InstructorGateway().Delete(instructor) > 0;
        }
        public Instructor Search(int id)
        {
            return new InstructorGateway().Search(id);
        }
        public Instructor SearchEmail(string email)
        {
            return new InstructorGateway().SearchEmail(email);
        }
        public Instructor SearchPhone(string phone)
        {
            return new InstructorGateway().SearchPhone(phone);
        }
        public Instructor SearchName(string name)
        {
            return new InstructorGateway().SearchName(name);
        }
    }
}
