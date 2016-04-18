using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Faceted_E_Commerce_Search.Models
{
    public class ColorModel
    {
        public int ColorId { get; set; }
        public string Color { get; set; }
    }
}