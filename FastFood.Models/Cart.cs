using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Required, MinLength(1)]
        public int Count { get; set; }


    }
}
