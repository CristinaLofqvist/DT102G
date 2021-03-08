using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DT102G_Moment_3_2.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public virtual ICollection<CD> CDs { get; set; }
        public Artist()
        {
        }
    }
}
