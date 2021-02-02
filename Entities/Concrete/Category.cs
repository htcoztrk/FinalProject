using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Cıplak class kalmasın !!!!!
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
