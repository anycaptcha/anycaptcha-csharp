using AnyCaptchaHelper.ApiResponse;
using AnyCaptchaHelper.Helper;
using Newtonsoft.Json.Linq;
using System.IO;

namespace AnyCaptchaHelper.Api
{
    internal class ImageToText : AnycaptchaBase, IAnycaptchaTaskProtocol
    {
        public enum NumericOption
        {
            NoRequirements,
            NumbersOnly,
            AnyLettersExceptNumbers
        }

        public ImageToText()
        {
            BodyBase64 = "";
            Phrase = false;
            Case = false;
            Numeric = NumericOption.NoRequirements;
            Math = 0;
            MinLength = 0;
            MaxLength = 0;
            SubType = "COMMON";
        }

        public string BodyBase64 { private get; set; }

        public string FilePath
        {
            set
            {
                if (!File.Exists(value))
                {
                }
                else
                {
                    BodyBase64 = StringHelper.ImageFileToBase64String(value);

                    if (BodyBase64 == null)
                    {
                    }
                }
            }
        }

        public bool Phrase { private get; set; }
        public bool Case { private get; set; }
        public NumericOption Numeric { private get; set; }
        public int Math { private get; set; }
        public int MinLength { private get; set; }
        public int MaxLength { private get; set; }
        public string SubType { get; set; }

        public override JObject GetPostData()
        {
            if (string.IsNullOrEmpty(BodyBase64))
            {
                return null;
            }

            return new JObject
            {
                {"type", "ImageToTextTask"},
                {"body", BodyBase64.Replace("\r", "").Replace("\n", "")},
                {"phrase", Phrase},
                {"case", Case},
                {"numeric", Numeric.Equals(NumericOption.NoRequirements) ? 0 : Numeric.Equals(NumericOption.NumbersOnly) ? 1 : 2},
                {"math", Math},
                {"minLength", MinLength},
                {"maxLength", MaxLength},
                {"subType", SubType}
            };
        }

        public TaskResultResponse.SolutionData GetTaskSolution()
        {
            return TaskInfo.Solution;
        }
    }
}