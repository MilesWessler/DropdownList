using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DropdownList.Models
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Instrument")]
        public int InstrumentId { get; set; }
        public virtual Instrument Instrument { get; set; }
    }
}
