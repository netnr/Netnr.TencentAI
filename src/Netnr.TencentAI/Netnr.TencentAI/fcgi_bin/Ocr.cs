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
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_idcardocr";
            return Aid.Request(request, uri);
        }

        [Description("行驶证驾驶证OCR")]
        public static string Ocr_DriverLicenseOcr(Ocr_DriverLicenseOcrRequest request)
        {
            var uri = "	https://api.ai.qq.com/fcgi-bin/ocr/ocr_driverlicenseocr";
            return Aid.Request(request, uri);
        }

        [Description("通用OCR")]
        public static string Ocr_GeneralOcr(Ocr_GeneralOcrRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_generalocr";
            return Aid.Request(request, uri);
        }

        [Description("营业执照OCR")]
        public static string Ocr_BizLicenseOcr(Ocr_BizLicenseOcrRequest request)
        {
            var uri = "	https://api.ai.qq.com/fcgi-bin/ocr/ocr_bizlicenseocr";
            return Aid.Request(request, uri);
        }

        [Description("银行卡OCR")]
        public static string Ocr_CreditCardOcr(Ocr_CreditCardOcrRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_creditcardocr";
            return Aid.Request(request, uri);
        }

        [Description("手写体OCR")]
        public static string Ocr_HandWritingOcr(Ocr_HandWritingOcrRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_handwritingocr";
            return Aid.Request(request, uri);
        }

        [Description("车牌体OCR")]
        public static string Ocr_PlateOcr(Ocr_PlateOcrRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_plateocr";
            return Aid.Request(request, uri);
        }

        [Description("名片OCR")]
        public static string Ocr_BcOcr(Ocr_BcOcrRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ocr/ocr_bcocr";
            return Aid.Request(request, uri);
        }
    }
}