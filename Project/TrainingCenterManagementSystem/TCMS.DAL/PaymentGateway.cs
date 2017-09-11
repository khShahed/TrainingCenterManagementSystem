using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class PaymentGateway
    {
        public List<Payment> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Payments.ToList();
            }
        }
        public int Save(Payment payment)
        {
            using (var context = new TCMSContext())
            {
                context.Payments.Add(payment);
                return context.SaveChanges();
            }
        }
        public int Update(Payment payment)
        {
            using (var context = new TCMSContext())
            {
                context.Payments.Attach(payment);
                context.Entry(payment).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Payment payment)
        {
            using (var context = new TCMSContext())
            {
                context.Payments.Attach(payment);
                context.Payments.Remove(payment);
                return context.SaveChanges();
            }
        }
        public Payment Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Payments.Find(id);
            }
        }
    }
}
