using System.Collections.Generic;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class TraineeManager
    {
        public List<Trainee> GetAll()
        {
            return new TraineeGateway().GetAll();
        }
        public bool Save(Trainee trainee)
        {
            return new TraineeGateway().Save(trainee) > 0;
        }
        public bool Update(Trainee trainee)
        {
            return new TraineeGateway().Update(trainee) > 0;
        }
        public bool Delete(Trainee trainee)
        {
            return new TraineeGateway().Delete(trainee) > 0;
        }
        public Trainee Search(int id)
        {
            return new TraineeGateway().Search(id);
        }
        public Trainee SearchEmail(string email)
        {
            return new TraineeGateway().SearchEmail(email);
        }
        public Trainee SearchPhone(string phone)
        {
            return new TraineeGateway().SearchPhone(phone);
        }
    }
}
