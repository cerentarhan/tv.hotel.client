using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;               
using System.Linq;
using System.Threading.Tasks;
using TourVisio.Hotel.Client.Models;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.AuthenticationModels;
using TourVisio.WebService.Client;

namespace TourVisio.Hotel.Client.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> signInManager;
        private UserManager<IdentityUser> userManager;
    
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;

        public AccountController(SignInManager<IdentityUser> signInManager,
           UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = "/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FormForm]LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                LoginRequest pRequest = new LoginRequest();
                pRequest.Agency = model.AgencyName;
                pRequest.User = model.UserName;
                pRequest.Password = model.Password;
                pRequest.WebRequestDetail = new mdlWebRequestDetail();
                pRequest.WebRequestDetail.ClientAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                pRequest.WebRequestDetail.UserAgent = Request.Headers["User-Agent"];
                pRequest.WebRequestDetail.Domain = Request.Host.Value;
                pRequest.WebRequestDetail.Referrer = Request.Headers["Referer"];
                pRequest.Version = GetType().Assembly.GetName().Version.ToString();
                AuthenticationRepository authentication = new AuthenticationRepository("xyz", "https://t3-services.tourvisio.com/v2/");
                var pResponse = authentication.Login(pRequest);

                if (pResponse.Header.Success)
                {
                    var user = new IdentityUser()
                    {
                        Id = pResponse.Body.Token,
                        UserName = pResponse.Body.UserInfo.Name
                    };

                    await _signInManager.SignInAsync(user, true);

                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach(var msg in pResponse.Header.Messages)
                    {
                        ModelState.AddModelError(msg.Code, msg.Message);
                    }
                }      
             }          
            
                        return View(model);
        }
        
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }

}




    

