using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faceted_E_Commerce_Search.Models
{
    public class FilterModel
    {
        public int ColorId { get; set; }
        public int OSId { get; set; }
        public int MakerId { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Diagonal { get; set; }
        public int RAM { get; set; }
        public int ReleaseYear { get; set; }
        public string ResolutionScreen { get; set; }
        public int PagesCount { get; set; }
        public int CurrentPage { get; set; }
        public bool SortByPrice { get; set; }
    }
}