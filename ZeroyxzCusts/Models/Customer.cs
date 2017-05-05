using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeroyxzCusts.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Email {get;set;}
        public string Twitter { get; set; }
        public string Self
        {
            get { return string.Format(CultureInfo.CurrentCulture, "api/customers/{0}", this.CustomerId); }
            set { }
        }

    }
}