using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Workers
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string CreatredAt { get; set; }
        public string BirthDate { get; set; }
    }
}
