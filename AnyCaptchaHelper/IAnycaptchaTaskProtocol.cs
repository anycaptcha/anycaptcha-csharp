using AnyCaptchaHelper.ApiResponse;
using Newtonsoft.Json.Linq;

namespace AnyCaptchaHelper
{
    internal interface IAnycaptchaTaskProtocol
    {
        JObject GetPostData();
        TaskResultResponse.SolutionData GetTaskSolution();
    }
}