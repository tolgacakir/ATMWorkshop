using ATM.BusinessLogicLayer.Abstract;
using ATM.BusinessLogicLayer.ValidationRules.FluentValidation;
using ATM.DataAccessLayer.Abstract;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.Aspects.KingAOP;
using TFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [FluentValidationAspect(typeof(CustomerValidator))]
        public Customer Login(string username, string password)
        {
            
            return _customerDal.Get(c => c.Username == username && c.Password == password);

        }

        [FluentValidationAspect(typeof(CustomerValidator))]
        public bool Logout(Customer customer)
        {
            throw new NotImplementedException();
        }

        [FluentValidationAspect(typeof(CustomerValidator))]
        public bool ChangePassword(Customer customer)
        {
            //ValidatorTool.FluentValidate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
            return true;
        }
    }
}
