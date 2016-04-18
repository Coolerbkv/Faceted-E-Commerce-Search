using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faceted_E_Commerce_Search.Models
{
    public class ModelList
    {
        public List<PhoneInfoModel> ListPage { get; set; }
        public int PagesCount { get; set; }
        public int CurrentPage { get; set; }
        public int FilterPhonesCount { get; set; }
    }
}