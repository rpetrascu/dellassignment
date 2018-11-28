using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dell.Models;
using NHibernate;
using Dell;

namespace Dell.Controllers
{
    public class CustomersController : Controller
    {
        [HttpPost]
        public JsonResult AddCustomer(Customer customer)
        {
            int customerId;
            using (ISession session = Nhibernate.sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var existingCustomer = session.QueryOver<Customer>().Where(x => x.Email == customer.Email).List().FirstOrDefault();
                if (existingCustomer != null)
                {
                    existingCustomer.Name = customer.Name;
                    session.Save(existingCustomer);
                    customerId = existingCustomer.Id;
                }
                else
                {
                    session.Save(customer);
                    customerId = customer.Id;
                }
                transaction.Commit();
            }
            return Json(new { Message = "Customer fully populated" , GeneratedCustomerId = customerId });
        }
    }
}