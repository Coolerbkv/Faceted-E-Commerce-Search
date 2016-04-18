using Faceted_E_Commerce_Search.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Data.Entity;
using Faceted_E_Commerce_Search.Abstract;

namespace Faceted_E_Commerce_Search.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IFacetedECommerceBusinessLogic dataManager;
        public ProductsController(IFacetedECommerceBusinessLogic _dataManager)
        {
            dataManager = _dataManager;
        }

        [HttpPost]
        [ActionName("Filter")]
        public HttpResponseMessage Filter(FilterModel filter)
        {
            return dataManager.Filter(filter);
        }

        [HttpGet]
        [ActionName("Product")]
        public HttpResponseMessage Get(int id)
        {
            return dataManager.GetProduct(id);
        }
        [HttpGet]
        [ActionName("GetColors")]
        public HttpResponseMessage Colors()
        {
            return dataManager.GetColors();
        }

        [HttpGet]
        [ActionName("GetOSs")]
        public HttpResponseMessage OSs()
        {
            return dataManager.GetOSs();
        }

        [HttpGet]
        [ActionName("GetMakers")]
        public HttpResponseMessage Makers()
        {
            return dataManager.GetMakers();
        }

        [HttpGet]
        [ActionName("GetCPUs")]
        public HttpResponseMessage CPUs()
        {
            return dataManager.GetCPUs();
        }

        [HttpGet]
        [ActionName("GetDiagonals")]
        public HttpResponseMessage Diagonals()
        {
            return dataManager.GetDiagonals();
        }

        [HttpGet]
        [ActionName("GetGPUs")]
        public HttpResponseMessage GPUs()
        {
            return dataManager.GetGPUs();
        }

        [HttpGet]
        [ActionName("GetRAMs")]
        public HttpResponseMessage RAMs()
        {
            return dataManager.GetRAMs();
        }

        [HttpGet]
        [ActionName("GetReleaseYears")]
        public HttpResponseMessage ReleaseYears()
        {
            return dataManager.GetReleaseYears();
        }

        [HttpGet]
        [ActionName("GetResolutionScreens")]
        public HttpResponseMessage ResolutionScreens()
        {
            return dataManager.GetResolutionScreens();
        }
    }
}
