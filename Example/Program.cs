using AnyCaptchaHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static readonly string clientkey = "INPUT YOUR API KEY";
        static void Main(string[] args)
        {
            var getBalanceRequest = new AnyCaptcha().GetBalance(clientkey);
            if (getBalanceRequest.IsSuccess)
                Console.WriteLine(getBalanceRequest.Balance);
            else
                Console.WriteLine(getBalanceRequest.Message);


            var imageToTextRequest = new AnyCaptcha().ImageToText(clientkey, "captcha.jpg", "COMMON");
            if (imageToTextRequest.IsSuccess)
                Console.WriteLine(imageToTextRequest.Result);
            else
                Console.WriteLine(imageToTextRequest.Message);

            var imageToTextFromBase64Request = new AnyCaptcha().ImageToTextFromBase64(clientkey,
                "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", "COMMON");
            if (imageToTextFromBase64Request.IsSuccess)
                Console.WriteLine(imageToTextFromBase64Request.Result);
            else
                Console.WriteLine(imageToTextFromBase64Request.Message);


            var hCaptchaRequest = new AnyCaptcha().HCaptchaProxyless(clientkey, "51829642-2cda-4b09-896c-594f89d700cc", "http://democaptcha.com/");
            if (hCaptchaRequest.IsSuccess)
                Console.WriteLine(hCaptchaRequest.Result);
            else
                Console.WriteLine(hCaptchaRequest.Message);


            var recaptchaV2ProxylessRequest = new AnyCaptcha().RecaptchaV2Proxyless(clientkey, "6Ld2tMEZAAAAAMbbdASE5Y3rIWSuuUOOWgRRIGh3", "http://bblink.com/INA6JdJ");
            if (recaptchaV2ProxylessRequest.IsSuccess)
                Console.WriteLine(recaptchaV2ProxylessRequest.Result);
            else
                Console.WriteLine(recaptchaV2ProxylessRequest.Message);


            var recaptchaV3ProxylessRequest = new AnyCaptcha().RecaptchaV3Proxyless(clientkey, "6Lf-TMIZAAAAAOD-4H1eJo2Rbiej7hv50_UkEvEt", "https://vico.vn/dang-tin-rao-vat.html", "", false);
            if (recaptchaV3ProxylessRequest.IsSuccess)
                Console.WriteLine(recaptchaV3ProxylessRequest.Result);
            else
                Console.WriteLine(recaptchaV3ProxylessRequest.Message);

            var funCaptchaProxylessRequest1 = new AnyCaptcha().FunCaptchaProxyless(clientkey, "E8A75615-1CBA-5DFF-8032-D16BCF234E10", "https://account.battle.net/creation/flow/creation-full");
            if (funCaptchaProxylessRequest1.IsSuccess)
                Console.WriteLine(funCaptchaProxylessRequest1.Result);
            else Console.WriteLine($"{funCaptchaProxylessRequest1.Message}");

            Console.ReadLine();
        }
    }
}
