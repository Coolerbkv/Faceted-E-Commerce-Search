using Faceted_E_Commerce_Search.Abstract;
using Faceted_E_Commerce_Search.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace Faceted_E_Commerce_Search.BusinessLogic
{
    public class ProductsManager : IFacetedECommerceBusinessLogic
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public HttpResponseMessage Filter(FilterModel filter)
        {
            IQueryable<PhoneInfoModel> request = db.PhoneModels;

            if (filter.ColorId != 0)
            {
                request = request.Where(n => n.Color.ColorId == filter.ColorId);
            }
            if (filter.MakerId != 0)
            {
                request = request.Where(n => n.Maker.MakerId == filter.MakerId);
            }
            if (filter.OSId != 0)
            {
                request = request.Where(n => n.OS.OSId == filter.OSId);
            }
            if (filter.CPU != null)
            {
                request = request.Where(n => n.CPU == filter.CPU);
            }
            if (filter.Diagonal != null)
            {
                request = request.Where(n => n.Diagonal == filter.Diagonal);
            }
            if (filter.GPU != null)
            {
                request = request.Where(n => n.GPU == filter.GPU);
            }
            if (filter.RAM != 0)
            {
                request = request.Where(n => n.RAM == filter.RAM);
            }
            if (filter.ReleaseYear != 0)
            {
                request = request.Where(n => n.ReleaseYear == filter.ReleaseYear);
            }
            if (filter.ResolutionScreen != null)
            {
                request = request.Where(n => n.ResolutionScreen == filter.ResolutionScreen);
            }
            if (filter.SortByPrice)
            {
                request = request.OrderBy(n => n.Price);
            }
            else
            {
                request = request.OrderByDescending(n => n.Price);
            }
            var allProducts = request.Count();
            request = request.Skip((filter.CurrentPage - 1) * 10).Take(10);
            var ListResponsePage = new ModelList()
            {
                ListPage = request.ToList(),
                CurrentPage = filter.CurrentPage,
                PagesCount = (int)Math.Ceiling((double)allProducts / 10),
                FilterPhonesCount = allProducts
            };
            var json = JsonConvert.SerializeObject(ListResponsePage);
            
            return GetResponse(json);
        }

        public HttpResponseMessage GetProduct(int id)
        {
            var json = JsonConvert.SerializeObject((db.PhoneModels.Where(n => n.PhoneId == id).SingleOrDefault()));

            return GetResponse(json);
        }

        public HttpResponseMessage GetColors()
        {
            var json = JsonConvert.SerializeObject((db.Colors));

            return GetResponse(json);
        }

        public HttpResponseMessage GetOSs()
        {
            var json = JsonConvert.SerializeObject((db.OperationSystems));

            return GetResponse(json);
        }

        public HttpResponseMessage GetMakers()
        {
            var json = JsonConvert.SerializeObject((db.MakerModels));

            return GetResponse(json);
        }

        public HttpResponseMessage GetCPUs()
        {
            return GetJSONResponse<string>(db.PhoneModels.Select(n => n.CPU).ToList());
        }

        public HttpResponseMessage GetDiagonals()
        {
            return GetJSONResponse<string>(db.PhoneModels.Select(n => n.Diagonal).ToList());
        }

        public HttpResponseMessage GetGPUs()
        {
            return GetJSONResponse<string>(db.PhoneModels.Select(n => n.GPU).ToList());
        }

        public HttpResponseMessage GetRAMs()
        {
            return GetJSONResponse<int>(db.PhoneModels.Select(n => n.RAM).ToList());
        }

        public HttpResponseMessage GetReleaseYears()
        {
            return GetJSONResponse<int>(db.PhoneModels.Select(n => n.ReleaseYear).ToList());
        }

        public HttpResponseMessage GetResolutionScreens()
        {
            return GetJSONResponse<string>(db.PhoneModels.Select(n => n.ResolutionScreen).ToList());
        }

        private HttpResponseMessage GetJSONResponse<T>(IEnumerable<T> models)
        {
            var json = JsonConvert.SerializeObject(models);

            return GetResponse(json);
        }
        private HttpResponseMessage GetResponse(string json)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(json)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }
    }
}