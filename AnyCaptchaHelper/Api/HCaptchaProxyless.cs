using System;
using AnyCaptchaHelper.ApiResponse;
using Newtonsoft.Json.Linq;

namespace AnyCaptchaHelper.Api
{
    internal class HCaptchaProxyless : AnycaptchaBase, IAnycaptchaTaskProtocol
    {
        public Uri WebsiteUrl { protected get; set; }
        public string WebsiteKey { protected get; set; }

        public override JObject GetPostData()
        {
            return new JObject
            {
                {"type", "HCaptchaTaskProxyless"},
                {"websiteURL", WebsiteUrl},
                {"websiteKey", WebsiteKey},
            };
        }

        public TaskResultResponse.SolutionData GetTaskSolution()
        {
            return TaskInfo.Solution;
        }

    }
}