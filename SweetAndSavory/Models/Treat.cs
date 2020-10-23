using System.Collections.Generic;

namespace SweetAndSavory.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Description { get; set; }
         public virtual ApplicationUser User { get; set; } // new line

        public ICollection<FlavorTreat> Flavors { get; }
    }
}