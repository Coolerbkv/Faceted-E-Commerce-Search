using Faceted_E_Commerce_Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Faceted_E_Commerce_Search.Abstract
{
    public interface IFacetedECommerceBusinessLogic
    {
        HttpResponseMessage Filter(FilterModel filter);
        HttpResponseMessage GetProduct(int id);
        HttpResponseMessage GetColors();
        HttpResponseMessage GetOSs();
        HttpResponseMessage GetMakers();
        HttpResponseMessage GetCPUs();
        HttpResponseMessage GetDiagonals();
        HttpResponseMessage GetGPUs();
        HttpResponseMessage GetRAMs();
        HttpResponseMessage GetReleaseYears();
        HttpResponseMessage GetResolutionScreens();
    }
}
