using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourVisio.Hotel.Client.Models
{
    public class LoginViewModel
    {
        internal readonly string returnUrl;


        public string AgencyName { get; set; }
        public IdentityUser AgencyCode { get; internal set; }


        public static string Name { get; internal set; }
     
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }
       

        
  
    }
}
