using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace People_Search_Application.Models
{
    public class People
    {
        [Key]
        public int personID { get; set; }
        
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string interests { get; set; }
        public string picture { get; set; }
    }

    public class PeopleContext : DbContext
    {
        public DbSet<People> Person { get; set; }
    }
}