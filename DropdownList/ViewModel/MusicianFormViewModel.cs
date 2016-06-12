using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DropdownList.Models;

namespace DropdownList.ViewModel
{
    public class MusicianFormViewModel
    {
        public Musician Musician { get; set; }
        public IEnumerable<Instrument> Instruments { get; set; }
    }
}