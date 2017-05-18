using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodCart.Models
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        public int user_id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string roles { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}