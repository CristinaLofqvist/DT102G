using System;
using System.ComponentModel.DataAnnotations;

namespace DT102G_Moment_3_2.Models
{
    public class CD
    {
        public int Id { get; set; }
        [Required] public string Title { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist{ get; set; }
        public CD()
        {
        }
    }
}
