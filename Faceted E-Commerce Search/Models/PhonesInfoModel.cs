using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faceted_E_Commerce_Search.Models
{
    public class PhoneInfoModel
    {
        public int  PhoneId { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string ResolutionScreen { get; set; }
        public int RAM { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PackageContents { get; set; }
        public string Diagonal { get; set; }
        public int ReleaseYear { get; set; }
        public virtual MakerModel Maker { get; set; }
        public virtual ColorModel Color { get; set; }
        public virtual OSModel OS { get; set; }
        public virtual List <PicturesLink> Pictures { get; set; }

    }
}