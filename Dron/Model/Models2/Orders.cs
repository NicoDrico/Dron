using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int? UsersId { get; set; }
        public string Status { get; set; }
        public int? WorkerId { get; set; }
        public int? CreatedAt { get; set; }
        public int? ProductId { get; set; }
    }
}
