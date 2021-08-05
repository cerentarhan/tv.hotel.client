using System;

namespace TourVisio.WebService.Client
{
    public class B2BException : Exception
    {
        public string RedirectUrl { get; set; }
        public bool EnableLog { get; set; }

        public B2BException(string pMessage, bool pEnableLog = false) : this(pMessage, null, pEnableLog)
        { }

        public B2BException(string pMessage, string pRedirectUrl, bool pEnableLog = false) : base(pMessage)
        {
            this.RedirectUrl = pRedirectUrl;
            this.EnableLog = pEnableLog;
        }

    }
}