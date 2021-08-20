using AnyCaptchaHelper.ApiResponse;
using Newtonsoft.Json.Linq;
using System;

namespace AnyCaptchaHelper.Api
{
    internal class RecaptchaV2Proxyless : AnycaptchaBase, IAnycaptchaTaskProtocol
    {
        public Uri WebsiteUrl { protected get; set; }
        public string WebsiteKey { protected get; set; }
        public string WebsiteSToken { protected get; set; }

        public override JObject GetPostData()
        {
            return new JObject
            {
                {"type", "RecaptchaV2TaskProxyless"},
                {"websiteURL", WebsiteUrl},
                {"websiteKey", WebsiteKey},
                {"websiteSToken", WebsiteSToken}
            };
        }

        public TaskResultResponse.SolutionData GetTaskSolution()
        {
            return TaskInfo.Solution;
        }
    }
}