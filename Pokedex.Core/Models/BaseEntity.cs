using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime RegisteredDate { get; set; }
        public DateTime? UpdatedDate { get; set; } //başta null
    }
}
