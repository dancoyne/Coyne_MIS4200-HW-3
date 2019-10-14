using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Coyne_MIS4200.Models;
using System.Data.Entity;

namespace Coyne_MIS4200.DAL
{
    public class MIS4200_Context : DbContext
    {    
        public MIS4200_Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Appoitment> Appoitment { get; set; }
    }
}