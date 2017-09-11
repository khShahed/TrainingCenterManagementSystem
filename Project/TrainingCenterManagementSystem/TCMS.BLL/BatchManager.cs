using System.Collections.Generic;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class BatchManager
    {
        public List<Batch> GetAll()
        {
            return new BatchGateway().GetAll();
        }
        public bool Save(Batch batch)
        {
            return new BatchGateway().Save(batch) > 0;
        }
        public bool Update(Batch batch)
        {
            return new BatchGateway().Update(batch) > 0;
        }
        public bool Delete(Batch batch)
        {
            return new BatchGateway().Delete(batch) > 0;
        }
        public Batch Search(int id)
        {
            return new BatchGateway().Search(id);
        }
        public Batch SearchName(string name)
        {
            return new BatchGateway().SearchName(name);
        }
    }
}
