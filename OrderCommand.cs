using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacNuget.Warehouse.Commands
{
    public abstract class OrderCommand
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
