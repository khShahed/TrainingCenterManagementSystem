using System;
using System.Collections.Generic;
using System.Linq;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class PaymentManager
    {
        public List<Payment> GetAll()
        {
            return new PaymentGateway().GetAll();
        }
        public bool Save(Payment payment)
        {
            return new PaymentGateway().Save(payment) > 0;
        }
        public bool Update(Payment payment)
        {
            return new PaymentGateway().Update(payment) > 0;
        }
        public bool Delete(Payment payment)
        {
            return new PaymentGateway().Delete(payment) > 0;
        }
        public Payment Search(int id)
        {
            return new PaymentGateway().Search(id);
        }

        public int EarningInThisMonth()
        {
            var payments = new PaymentGateway().GetAll();
            var selected = from payment in payments
                           where payment.Date > DateTime.Now.AddMonths(-1)
                           select payment;
            var sum = 0;
            foreach (var payment in selected)
            {
                sum += payment.Amount;
            }
            return sum;
        }
    }
}
