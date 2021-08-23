using AnyCaptchaHelper.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCaptchaHelper
{
    public class AnyCaptcha
    {
        public BalanceResult GetBalance(string clientKey)
        {
            BalanceResult result = new BalanceResult();
            try
            {
                var api = new ImageToText
                {
                    ClientKey = clientKey
                };

                var balance = api.GetBalance();

                if (balance == null)
                {
                    result.Message = api.ErrorMessage;
                }
                else
                {
                    result.Message = "Success";
                    result.Balance = balance.Value;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult ImageToText(string clientKey, string filePath, string subType = "COMMON", int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {
                var api = new ImageToText
                {
                    ClientKey = clientKey,
                    FilePath = filePath
                };

                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().Text;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult HCaptchaProxyless(string clientKey, string websiteKey, string websiteURL, int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {

                var api = new HCaptchaProxyless
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsiteKey = websiteKey
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().GRecaptchaResponse;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult RecaptchaV2Proxyless(string clientKey, string websiteKey, string websiteURL, int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {
                var api = new RecaptchaV2Proxyless
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsiteKey = websiteKey
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().GRecaptchaResponse;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult RecaptchaV2(string clientKey, string websiteKey, string websiteURL, string UserAgent,
            ProxyTypeOption proxyType, string proxyAddress, int? proxyPort, string proxyLogin, string proxyPassword, int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {
                var api = new RecaptchaV2
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsiteKey = websiteKey,
                    UserAgent = UserAgent,
                    ProxyType = proxyType,
                    ProxyAddress = proxyAddress,
                    ProxyPort = proxyPort,
                    ProxyLogin = proxyLogin,
                    ProxyPassword = proxyPassword
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().GRecaptchaResponse;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult RecaptchaV3Proxyless(string clientKey, string websiteKey, string websiteURL, string pageAction, bool isEnterprise = false, int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {
                var api = new RecaptchaV3Proxyless
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsiteKey = websiteKey,
                    PageAction = pageAction,
                    IsEnterprise = isEnterprise
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().GRecaptchaResponse;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public AnyCaptchaResult FunCaptchaProxyless(string clientKey, string websiteKey, string websiteURL, int timeoutSecond = 145)
        {
            AnyCaptchaResult result = new AnyCaptchaResult();
            try
            {

                var api = new FunCaptchaProxyless
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsitePublicKey = websiteKey
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = api.GetTaskSolution().Token;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
        public GeetestResult GeetestProxyless(string clientKey, string websiteKey, string websiteURL, string websiteChallenge, int timeoutSecond = 145)
        {
            GeetestResult result = new GeetestResult();
            try
            {

                var api = new GeeTestProxyless
                {
                    ClientKey = clientKey,
                    WebsiteUrl = new Uri(websiteURL),
                    WebsiteKey = websiteKey,
                    WebsiteChallenge = websiteChallenge
                };
                if (!api.CreateTask())
                {
                    result.Message = api.ErrorMessage;
                }
                else if (!api.WaitForResult(timeoutSecond))
                {
                    result.Message = "Could not solve the captcha.";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Result = new GeetestSolvedResult()
                    {
                        Challenge = api.GetTaskSolution().Challenge,
                        Seccode = api.GetTaskSolution().Seccode,
                        Validate = api.GetTaskSolution().Validate
                    };
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }

    }

    public class BalanceResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public double Balance { get; set; }
    }
    public class AnyCaptchaResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }

    public class GeetestResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public GeetestSolvedResult Result { get; set; }
    }
    public class GeetestSolvedResult
    {
        public string Challenge { get; set; }
        public string Seccode { get; set; }
        public string Validate { get; set; }
    }
}
