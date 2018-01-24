using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleImageUpload.Database
{
    public class ImageUploadDbContext:DbContext
    {
        public System.Data.Entity.DbSet<SimpleImageUpload.Models.Brand> Brands { get; set; }
    }
}