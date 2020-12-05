using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Esports.API.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string GamerTag { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}
