using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın -- interface implementasyonu alsın gibisinden
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
