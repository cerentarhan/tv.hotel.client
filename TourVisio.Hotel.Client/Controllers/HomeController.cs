using TourVisio.Hotel.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TourVisio.WebService.Client;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.LookupModels;
using TourVisio.WebService.Adapter.Enums;
using TourVisio.WebService.Adapter.ServiceModels.ProductModels;
using TourVisio.WebService.Adapter.Models;

namespace TourVisio.Hotel.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            if (User != null && User.Identity.IsAuthenticated)
            {
                var pRequest = new GetCurrenciesRequest() { SearchType = enmCurrencySearchType.ForSearch };

                LookupRepository lookUp = new LookupRepository(User.Claims.First().Value, "https://t3-services.tourvisio.com/v2/");
                var rResponse = lookUp.GetCurrencies(pRequest);


                IndexViewModel c1 = new IndexViewModel();
                if (rResponse.Header.Success)
                {
                    c1.Currencies = rResponse.Body.Currencies;
                }


                var pRequest1 = new GetNationalitiesRequest();
                LookupRepository lookup1 = new LookupRepository(User.Claims.First().Value, "https://t3-services.tourvisio.com/v2/");
                var rResponse1 = lookup1.GetNationalities(pRequest1);

                if (rResponse1.Header.Success)
                {
                    c1.Nationalities = rResponse1.Body.Nationalities;
                }

                return View(c1);
            }

            return View();
        }
        public IActionResult Location(string term)
        {

            if (User != null && User.Identity.IsAuthenticated)
            {
                var pRequest2 = new GetArrivalAutoCompleteRequest()
                {
                    Query = term,
                    ProductType = enmProductType.Hotel
                };


                ProductRepository productRepo = new ProductRepository(User.Claims.First().Value, "https://t3-services.tourvisio.com/v2/");
                var rResponse2 = productRepo.GetArrivalAutoComplete(pRequest2);



                if (rResponse2.Header.Success)
                {
                    return Json(rResponse2.Body.Items);
                }

            }

            return Json("ERROR!!!");
        }

        [HttpPost]
        public ActionResult Search([FromBody] SearchViewModel searchForm)
        {
            SearchResultModel result = new SearchResultModel();

            if (User != null && User.Identity.IsAuthenticated)
            {
                var roomCriteria = new List<mdlRoomCriteria>();
                var room1 = new mdlRoomCriteria();
                room1.Adult = searchForm.Adult1;
                var childAges1 = new List<int>();
                if (searchForm.Child1 > 0)
                {
                    if (searchForm.ChildAge11 > 0)
                    {
                        childAges1.Add(searchForm.ChildAge11);
                    }
                    if (searchForm.ChildAge12 > 0)
                    {
                        childAges1.Add(searchForm.ChildAge12);
                    }
                    if (searchForm.ChildAge13 > 0)
                    {
                        childAges1.Add(searchForm.ChildAge13);
                    }
                    if (searchForm.ChildAge14 > 0)
                    {
                        childAges1.Add(searchForm.ChildAge14);
                    }
                    room1.ChildAges = childAges1;
                }
                roomCriteria.Add(room1);

                if (searchForm.Room >= 2)
                {
                    var room2 = new mdlRoomCriteria();
                    room2.Adult = searchForm.Adult2;
                    var childAges2 = new List<int>();
                    if (searchForm.Child2 > 0)
                    {
                        if (searchForm.ChildAge21 > 0)
                        {
                            childAges2.Add(searchForm.ChildAge21);
                        }
                        if (searchForm.ChildAge22 > 0)
                        {
                            childAges2.Add(searchForm.ChildAge22);
                        }
                        if (searchForm.ChildAge23 > 0)
                        {
                            childAges2.Add(searchForm.ChildAge23);
                        }
                        if (searchForm.ChildAge24 > 0)
                        {
                            childAges2.Add(searchForm.ChildAge24);
                        }
                        room2.ChildAges = childAges2;

                    }
                    roomCriteria.Add(room2);
                }

                if (searchForm.Room >= 3)
                {
                    var room3 = new mdlRoomCriteria();
                    room3.Adult = searchForm.Adult3;
                    var childAges3 = new List<int>();
                    if (searchForm.Child3 > 0)
                    {
                        if (searchForm.ChildAge31 > 0)
                        {
                            childAges3.Add(searchForm.ChildAge31);
                        }
                        if (searchForm.ChildAge32 > 0)
                        {
                            childAges3.Add(searchForm.ChildAge32);
                        }
                        if (searchForm.ChildAge33 > 0)
                        {
                            childAges3.Add(searchForm.ChildAge33);
                        }
                        if (searchForm.ChildAge34 > 0)
                        {
                            childAges3.Add(searchForm.ChildAge34);
                        }
                        room3.ChildAges = childAges3;

                    }
                    roomCriteria.Add(room3);
                }
                if (searchForm.Room >= 4)
                {
                    var room4 = new mdlRoomCriteria();
                    room4.Adult = searchForm.Adult4;
                    var childAges4 = new List<int>();
                    if (searchForm.Child4 > 0)
                    {

                        if (searchForm.ChildAge41 > 0)
                        {
                            childAges4.Add(searchForm.ChildAge41);
                        }
                        if (searchForm.ChildAge42 > 0)
                        {
                            childAges4.Add(searchForm.ChildAge42);
                        }
                        if (searchForm.ChildAge43 > 0)
                        {
                            childAges4.Add(searchForm.ChildAge43);
                        }
                        if (searchForm.ChildAge44 > 0)
                        {
                            childAges4.Add(searchForm.ChildAge44);
                        }
                        room4.ChildAges = childAges4;

                    }
                    roomCriteria.Add(room4);
                }
                var checkIn =  DateTime.Parse(searchForm.CheckInDate);
                var checkOut = DateTime.Parse(searchForm.CheckOutDate);

                var pRequest3 = new PriceSearchRequest()
                {

                    Nationality = searchForm.Nationality,
                    CheckIn = checkIn,
                    Night = (checkOut - checkIn).Days,
                    RoomCriteria = roomCriteria,
                    Currency = searchForm.Currency,
                    ProductType = enmProductType.Hotel

                };

                if (searchForm.LocationType == 2)
                {
                    var products = new List<string>();
                    products.Add(searchForm.LocationId);
                    pRequest3.Products = products;
                } 
                else

                {
                    var locations = new List<mdlLocation>();
                    var location = new mdlLocation();
                    location.Id = searchForm.LocationId;
                    locations.Add(location);
                    pRequest3.ArrivalLocations = locations;
                }

                 ProductRepository productRepo1 = new ProductRepository(User.Claims.First().Value, "https://t3-services.tourvisio.com/v2/");
                var rResponse3 = productRepo1.PriceSearch(pRequest3);

                if (rResponse3.Header.Success)
                {
                    result.Hotels = rResponse3.Body.Hotels;
                }
                else
                {
                    result.ErrorMsg = rResponse3.Header.Messages.First().Message; 
                } 
            } else

            {
                result.ErrorMsg = "Please Login first!!!";
            }

            return PartialView("SearchResult", result);
        }   

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    } 
}
