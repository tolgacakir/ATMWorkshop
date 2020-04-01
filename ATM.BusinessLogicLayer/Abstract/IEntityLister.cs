using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface IEntityLister<Tin, Tout>
        where Tin : IEntity
        where Tout : IEntity
    {
        IList<Tout> GetList(Tin input);
        
    }
}
