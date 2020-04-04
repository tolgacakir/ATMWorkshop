using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class Bill : IEntity 
    {
        public PropertyInfo[] PropertiesForDal { get; private set; }
    }
}
