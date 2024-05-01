using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public int? TelephoneNumber { get; set; }
        public string Address { get; set; }
    }
}
