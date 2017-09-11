using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class PaymentMethodGateway
    {
        public List<PaymentMethod> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.PaymentMethods.ToList();
            }
        }
        public int Save(PaymentMethod paymentMethod)
        {
            using (var context = new TCMSContext())
            {
                context.PaymentMethods.Add(paymentMethod);
                return context.SaveChanges();
            }
        }
        public int Update(PaymentMethod paymentMethod)
        {
            using (var context = new TCMSContext())
            {
                context.PaymentMethods.Attach(paymentMethod);
                context.Entry(paymentMethod).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(PaymentMethod paymentMethod)
        {
            using (var context = new TCMSContext())
            {
                context.PaymentMethods.Attach(paymentMethod);
                context.PaymentMethods.Remove(paymentMethod);
                return context.SaveChanges();
            }
        }
        public PaymentMethod Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.PaymentMethods.Find(id);
            }
        }
        public PaymentMethod SearchName(string name)
        {
            using (var context = new TCMSContext())
            {
                return context.PaymentMethods.FirstOrDefault(e => e.Name == name);
            }
        }
    }
}
