using System.Collections.Generic;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class PaymentMethodManager
    {
        public List<PaymentMethod> GetAll()
        {
            return new PaymentMethodGateway().GetAll();
        }
        public bool Save(PaymentMethod paymentMethod)
        {
            return new PaymentMethodGateway().Save(paymentMethod) > 0;
        }
        public bool Update(PaymentMethod paymentMethod)
        {
            return new PaymentMethodGateway().Update(paymentMethod) > 0;
        }
        public bool Delete(PaymentMethod paymentMethod)
        {
            return new PaymentMethodGateway().Delete(paymentMethod) > 0;
        }
        public PaymentMethod Search(int id)
        {
            return new PaymentMethodGateway().Search(id);
        }
        public PaymentMethod SearchName(string name)
        {
            return new PaymentMethodGateway().SearchName(name);
        }
    }
}
