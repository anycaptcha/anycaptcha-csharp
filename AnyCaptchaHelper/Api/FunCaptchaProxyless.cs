using System;
using AnyCaptchaHelper.ApiResponse;
using AnyCaptchaHelper.Helper;
using Newtonsoft.Json.Linq;

namespace AnyCaptchaHelper.Api
{
    internal class FunCaptchaProxyless : AnycaptchaBase, IAnycaptchaTaskProtocol
    {
        public Uri WebsiteUrl { protected get; set; }
        public string WebsitePublicKey { protected get; set; }
        public override JObject GetPostData()
        {
            return new JObject
            {
                {"type", "FunCaptchaTaskProxyless"},
                {"websiteURL", WebsiteUrl},
                {"websitePublicKey", WebsitePublicKey},
            };
        }

        public TaskResultResponse.SolutionData GetTaskSolution()
        {
            return TaskInfo.Solution;
        }
    }
}