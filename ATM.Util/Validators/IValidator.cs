using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Util.Validators
{
    public interface IValidator
    {
        bool Validate(object obj);
    }
}
