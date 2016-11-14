using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoName { get; set; }
    }
}