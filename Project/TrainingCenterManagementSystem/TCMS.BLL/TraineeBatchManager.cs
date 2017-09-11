using System.Collections.Generic;
using System.Linq;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class TraineeBatchManager
    {
        public List<TraineeBatch> GetAll()
        {
            return new TraineeBatchGateway().GetAll();
        }

        public bool Save(TraineeBatch traineeBatch)
        {
            return new TraineeBatchGateway().Save(traineeBatch) > 0;
        }
        public bool Update(TraineeBatch traineeBatch)
        {
            return new TraineeBatchGateway().Update(traineeBatch) > 0;
        }
        public bool Delete(TraineeBatch traineeBatch)
        {
            return new TraineeBatchGateway().Delete(traineeBatch) > 0;
        }
        public TraineeBatch Search(int id)
        {
            return new TraineeBatchGateway().Search(id);
        }

        public bool SearchTrainee(int batchId, int traineeId)
        {
            var selected = GetAll().FirstOrDefault(tb => tb.BatchId == batchId && tb.TraineeId == traineeId);
            return selected != null;
        }
    }
}
