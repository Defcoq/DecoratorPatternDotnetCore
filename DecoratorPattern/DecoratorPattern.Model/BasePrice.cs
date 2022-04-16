using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class BasePrice : IPrice 
    { 
        private Decimal _cost; 
        public decimal Cost { 
            get { return _cost; } 
            set { _cost = value; } 
        } 
    }
}
