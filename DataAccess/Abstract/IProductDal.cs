using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface methodları default olarak public tir ama kendisi public değil internaldir o yüzden interfaceyi public yaptık
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
