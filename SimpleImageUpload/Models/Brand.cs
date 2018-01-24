using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleImageUpload.Models
{
    public partial class Brand
    {
        public int BrandId { get; set; }
        public byte[] BrandImage { get; set; }
    }
}