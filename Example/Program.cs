using AnyCaptchaHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static readonly string clientkey = "input your anycaptcha key here";
        static void Main(string[] args)
        {
            var getBalanceRequest = new AnyCaptcha().GetBalance(clientkey);
            if (getBalanceRequest.IsSuccess)
                Console.WriteLine(getBalanceRequest.Balance);
            else
                Console.WriteLine(getBalanceRequest.Message);


            var imageToTextRequest = new AnyCaptcha().ImageToText(clientkey, "captcha.jpg", "COMMON", 145);
            if (imageToTextRequest.IsSuccess)
                Console.WriteLine(imageToTextRequest.Result);
            else
                Console.WriteLine(imageToTextRequest.Message);


            var hCaptchaRequest = new AnyCaptcha().HCaptchaProxyless(clientkey, "51829642-2cda-4b09-896c-594f89d700cc", "http://democaptcha.com/");
            if (hCaptchaRequest.IsSuccess)
                Console.WriteLine(hCaptchaRequest.Result);
            else
                Console.WriteLine(hCaptchaRequest.Message);


            var recaptchaV2ProxylessRequest = new AnyCaptcha().RecaptchaV2Proxyless(clientkey, "6Lc_aCMTAAAAABx7u2W0WPXnVbI_v6ZdbM6rYf16", "http://http.myjino.ru/recaptcha/test-get.php");
            if (recaptchaV2ProxylessRequest.IsSuccess)
                Console.WriteLine(recaptchaV2ProxylessRequest.Result);
            else
                Console.WriteLine(recaptchaV2ProxylessRequest.Message);



            var recaptchaV3ProxylessRequest = new AnyCaptcha().RecaptchaV3Proxyless(clientkey, "6Leva6oUAAAAAMFYqdLAI8kJ5tw7BtkHYpK10RcD", "http://www.supremenewyork.com", "testPageAction", false);
            if (recaptchaV3ProxylessRequest.IsSuccess)
                Console.WriteLine(recaptchaV3ProxylessRequest.Result);
            else
                Console.WriteLine(recaptchaV3ProxylessRequest.Message);



            var funCaptchaProxylessRequest = new AnyCaptcha().FunCaptchaProxyless(clientkey, "B7D8911C-5CC8-A9A3-35B0-554ACEE604DA", "https://outlook.live.com");
            if (funCaptchaProxylessRequest.IsSuccess)
                Console.WriteLine(funCaptchaProxylessRequest.Result);
            else
                Console.WriteLine(funCaptchaProxylessRequest.Message);

        }
    }
}
