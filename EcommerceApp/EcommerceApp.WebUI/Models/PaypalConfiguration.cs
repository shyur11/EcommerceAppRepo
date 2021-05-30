using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceApp.WebUI.Models
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;

        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AfiD0TfeLvtc11Eclnxf1pRAPt0493Rfb0Xxjm4T_GQsBJj6D-nsRQ7VxniWTy9xwMrl_gxY_MKwR8-s";
            clientSecret = "ENITv1efCQCV4unslWg4ZZhiZWeFxzONz3EumorBH_N4t6jXFEVrfcqE3Igy5u6sa2uxh5gJxBhbGmx7";
        }

        private static Dictionary<string,string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            // return apicontext object by invoking it with the accesstoken
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = getconfig();
            return apiContext;
        }
    }
}