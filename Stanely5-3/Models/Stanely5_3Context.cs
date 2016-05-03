using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stanely5_3.Models
{
    public class Stanely5_3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Stanely5_3Context() : base("name=Stanely5_3Context")
        {
        }

        public System.Data.Entity.DbSet<Stanely5_3.Models.PropertyModel> PropertyModels { get; set; }

        public System.Data.Entity.DbSet<Stanely5_3.Models.Customers> Customers { get; set; }
    }
}
