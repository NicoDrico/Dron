using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? Price { get; set; }

        public virtual Categories Categories { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
