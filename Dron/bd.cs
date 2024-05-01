/*using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Orders>();
        }

        public int IdClient { get; set; }
        public string Name { get; set; }
        public int TelephoneNumber { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Jobs
    {
        public Jobs()
        {
            Workers = new HashSet<Workers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }

        public virtual ICollection<Workers> Workers { get; set; }
    }
}

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

        public virtual Client Users { get; set; }
        public virtual Workers Worker { get; set; }
    }
}

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

        public virtual Categories Category { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Dron.Model.Models22
{
    public partial class Workers
    {
        public Workers()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int? JobId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string CreatredAt { get; set; }
        public string BirthDate { get; set; }

        public virtual Jobs Job { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}*/