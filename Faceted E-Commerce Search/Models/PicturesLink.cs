using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Faceted_E_Commerce_Search.Models
{
    public class PicturesLink
    {
        public int PictureId { get; set; }
        public string PictureLink { get; set; }
        public int? PhoneModelId { get; set; }
        [ForeignKey("PhoneModelId")]
        public virtual PhoneInfoModel PhoneModel { get; set; }
    }
}