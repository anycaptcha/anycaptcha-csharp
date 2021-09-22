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
        static readonly string clientkey = "input client key here";
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
                "/9j/4AAQSkZJRgABAQAAAQABAAD//gATNzBlNjhjZDc4OTc0MzIxYgD/2wBDAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDL/2wBDAQkJCQwLDBgNDRgyIRwhMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjL/wAARCABGAMgDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD32iiigAooooAKKhurqGzt2nuH2RL1bBOPyrIj8Z+HZbpLZNVhMzuEVcMMsTgDpUucY6NmkKNSavCLa8kbtFFFUZhRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAOHSigdKKAG0UUUAFFFFAB1615l8VPDaG1j120iCSREJcbBjKn7rfgePxHpXptQXlpDf2U9pcLuhmQo49QRisq1JVIOLOrBYqWGrRqLpv6GN4L14eIfDVvdO2bmP91P/AL47/iMH8a6CvHvBN1N4S8dXWgXjYiuH8oE9C45RvxBx/wACFew1GGqOcNd1ozbMsMqFd8nwy1XowoooroPPCiiigAooqlqOr6fpEavqF3Fbq+dpkOM49KTaSuyoxlJ8sVdl2iuS1nx/pFlobX9lOLwmXyFWM4O7Ge47D2rkLfx3rdprUaSXJ1C2u7bfap5KqWZh8oOB1DAqfxrCeKpxdr3O+jleIqxcrWt30vb+up65RXkaeMPFfhnXIV8RoXtZzkqVHC9ypHp6GvSNY8QWGiaT/aN1J+5YDywvJcnkAU6eIhNN7W3uRXy+rRlFK0ubZrW5qUV59Y+N/EWuJJPo3h5JLZDjfLLjJ9O1SaZ8SoW1P+zdbsX064DbCxOVB9/ShYmm7a7jeWYlX0u1uk02vkd7RVDU9a0/R7Zbi+uUijbhe5b6AcmsW1+IGg3uqQafBJcGeZwi7oSoyemc4rSVSEXZvU54YatUi5wi2u9jqaKKKswHDpRQOlFADaKKKACmu6xozuwVVGST0Ap1QXtql9Y3FpISEmjaMkdQCMUntoONrq+xzs/xE8MwTGI35dgcfu4mYfmBVrT/ABr4e1KURQalEsjHASXKE/nWBo3wzi0TWYL+G/8APWMndHNEDuBFVPid4WgfTf7ZsoVjngI88IMbkPGfqOPwrkdTERg5yS06HsRw+X1KsaNOUtevn6W/Ui+K+jMgtPEFrlZImEUrL1HOUb8Dx+Io0/xX4v8AEUb3ujW1t5FqqrLC4BMr4ycf5FR+AdWHiXQ7/wAManKZD5J8lm5Ozp+anBH/ANaofhhdSaR4j1Lw/d/JKxO0f7aZBA+o5/CsFLmqKcXZS/NHfKDp4edKpFSnS2v1i/6+RuTePFvvBOpX1sht9StVCSwN1jYsFyPbmse303xFB4WtvEml63dXFy0fnTW8p3qw7gA+npVD4l6W2ja4dRthtttTiZJlHQuMZz/4631Bro/hTq4utCn0qU/vrOQlVP8Acbn9Dn8xTUnOt7Oo9Uvx7/cRKnCjg/rOHScW02nrps18mUoPiTqt9pE13ZafZvJaIGuY3dtwHd1Hdfx4rT8CeObnxPe3dpfRQRSogkiEQIyM4bOSfUVxGrWg8JfEZkVcWNwwJTs0MnDL+HzD8BWfpM0nhDx6iysQttcmGQ/3ozxn8jms1iKkJrnezszpnl+Gq0Zeyirtc0e/p/Xc9I8YSeK9H0ybUrLV43gjOXj+zIGVScZzznrVTwFrMni/S9S07XGW7kUggugB2MMcYHYjr713d/aR6jp1xZy8xzxNGfoRivFPAN1JoXj1LOf5fNZ7SQf7WeP/AB5R+db1b060Xf3XoefhFHEYOolFKcNU0kn+HoXfBGjWcnibWdA1KMSMkUkce/kAhtpYD1xg59qt+L9Fi8ISeGL21LMlpJskc9SQwf8AXL8VY14f8I/8X9P1AfLDelNx7fMPLb+hro/idaLc+CbiQ43W8scq59c7f5MazVNKlNW1j/w51SxM3iqM2/cqJXXS7Ti/zKnxWslu/CUd4gBNtOr7h/db5f5la4jxVqEl94J8LMWJRY5I2/3kIX+Q/Wu7F3BrvwlkZ5VLLYFXyekkY7/ioP4159pkKa34DutOR1N/Y3JuYIifmdGUBgvr0zU4j3pXj9pfkXl37umlP/l3Nr5NW/M6PwZ41h0rw3BYppN/cyxs25oI9ykk56/TFYni6PU/FWspfWXh3UYP3YRg0LZYgnnp71J8PfGMPh6aax1AlbOdtwcDPlv05HpXqreK9BS3886ta+XjPEgJ/LrTppVqSjKe3QnEyngsXKpTo3b63bvc8eutT1XS9V0CfXLGbbZIAsU643qGPOD3xj8hXoU0Wi+MnsdU0aaFdQs545cEbW2hgSrD6dDVe8vNJ8dLHZ3trJbwzSSLp12eC5UDOB756d8VxeqeG9Y8AanbapDKJbdJQFmj4z/ssPcZpa07v4ofiivdxHLF/u6qvZdHe+n6Pqe50U1HEkauOjAEU6vVPlBw6UUDpRQA2iiigAooooA89+KOuappNvYxWEzQRz798idcjHGe3WofCfhiw8R+HIr2+1G/upZdwlX7SwCnOMEZrsvEfh+18SaS9jc5U53RyAcow6GvNrLwJ4z0W8ddMvUjiY8yJLhW+qnvXBVhNVuZx5ov8D38JWpTwfsozVOae/f5nOMLnwN45H3j9kmyP+mkR/xU/nXVeOLOa11yw8X6IvnROqySPFyAy9CcdivH4GtOb4Yy6pbPPq2rzTakwAWUDKr7Y7ipvBngS+0DVZLm/u0miRCkMcbErz1JBrGNCovcto3deR2Vcfh3atzpzirNWdpL/hxnjLUdN8TfDh9Qt5kLRtHKqFhuR84KkeuCax4NL1Hw3HpHi3TYHmiktYxf26jnBUZbHvgH2Nd3deCvD15c/aJdNjDk7iEJUMfcDg1vIixoqIoVVGAB0ArqeHlOXNLfy/M8uOYU6NJUqSbi27p9n0/4Oh5F4juLbx34r0hNHWSQKgE7shHljdnn6c0z4saE9vqcOsRRnyZ0EcpA6OOmfqMflXrkVtBASYoY4y3UogGabeWVvqFrJa3cKzQSDDIwyDSlheaMrvVlUs19lVpuEfdimrXu7Pc4Lwz8StK/sWCDVZnhuoECE7SwkAGM59a8+8S3/m+Km1uygkghmlE8DOMbipGWH4jNesQfDXw1Bc+eLSR+chHkJUfhWxqHhrR9UW3W90+KVbcERA5AUHGRx9BWcsPWqQUZtaHRSzDBYeu6lKMrS32/BepwPjOG98a/2XcaDZNOkUZczLIowWx8vJyCCK7C1sbnxFpC2vijSVjaPacCfKyNg5Pynj6H1rV07RtN0kONPsobbfjd5a43Y9avV0QoWblJ6vfsedWx14RpUlZR2evMr/MxIPCGgW1tLbxabGsM2PMQsxDY6ZyaltvDGhWcqy2+k2kciHKusQyD9a1qK1VOC6I5XiKzveb182clrHw60HV7hrgxPbTOcs0BwCfXHSqth8LPD9nMskpuLrBztlcY/QCu3oqHh6Td+VGyzDFRhyKo7HL+LfCj65plnBp00dnNZyb4SBgDjGBjp2/KsufQ/Feu2MOk601ktmsitLPGxMkgU5xjsT613lFEqEZNvuFPHVYQUdHbVNrVeggAVQAMADApaKK2OMcOlFA6UUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFAH//Z", "COMMON");
            if (imageToTextFromBase64Request.IsSuccess)
                Console.WriteLine(imageToTextFromBase64Request.Result);
            else
                Console.WriteLine(imageToTextFromBase64Request.Message);


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


            var recaptchaV3ProxylessRequest = new AnyCaptcha().RecaptchaV3Proxyless(clientkey, "6Lf-TMIZAAAAAOD-4H1eJo2Rbiej7hv50_UkEvEt", "https://vico.vn/dang-tin-rao-vat.html", "", false);
            if (recaptchaV3ProxylessRequest.IsSuccess)
                Console.WriteLine(recaptchaV3ProxylessRequest.Result);
            else
                Console.WriteLine(recaptchaV3ProxylessRequest.Message);


            var funCaptchaProxylessRequest = new AnyCaptcha().FunCaptchaProxyless(clientkey, "B7D8911C-5CC8-A9A3-35B0-554ACEE604DA", "https://outlook.live.com");
            if (funCaptchaProxylessRequest.IsSuccess)
                Console.WriteLine(funCaptchaProxylessRequest.Result);
            else
                Console.WriteLine(funCaptchaProxylessRequest.Message);


            var zaloRequest = new AnyCaptcha().Zalo(clientkey);
            if (zaloRequest.IsSuccess)
                Console.WriteLine(zaloRequest.Result);
            else
                Console.WriteLine(zaloRequest.Message);

        }
    }
}
