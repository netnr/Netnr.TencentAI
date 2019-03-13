using Netnr.TencentAI.Model;
using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    [Description("OCR")]
    public class Ocr
    {
        [Description("身份证OCR")]
        public static string Ocr_IdCardOcr(Ocr_IdCardOcrRequest request)
        {
            if (Aid.IsValid(request))
            {
                var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_idcardocr";
                var result = HttpTo.Post(uri, Aid.Parameter(request));
                return result;
            }
            return Aid.ValidFail();
        }

        [Description("行驶证驾驶证OCR")]
        public static string Ocr_DriverLicenseOcr()
        {
            return "";
        }

        [Description("通用OCR")]
        public static string Ocr_GeneralOcr(Ocr_GeneralOcrRequest request)
        {
            if (Aid.IsValid(request))
            {
                var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_generalocr";
                var result = HttpTo.Post(uri, Aid.Parameter(request));
                return result;
            }
            return Aid.ValidFail();
        }

        [Description("营业执照OCR")]
        public static string Ocr_BizLicenseOcr()
        {
            return "";
        }

        [Description("银行卡OCR")]
        public static string Ocr_CreditCardOcr()
        {
            return "";
        }

        [Description("手写体OCR")]
        public static string Ocr_HandWritingOcr()
        {
            return "";
        }

        [Description("车牌体OCR")]
        public static string Ocr_PlateOcr()
        {
            return "";
        }

        [Description("名片OCR")]
        public static string Ocr_BcOcr()
        {
            return "";
        }
    }
}