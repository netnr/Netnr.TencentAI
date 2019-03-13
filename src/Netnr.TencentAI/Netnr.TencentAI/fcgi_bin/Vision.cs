using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    public class Vision
    {
        [Description("图片特效>图片滤镜（AI Lab）,更适合风景图片")]
        public static string Vision_ImgFilter()
        {
            return "";
        }

        [Description("图片识别>看图说话")]
        public static string Vision_ImgToText()
        {
            return "";
        }

        [Description("图片识别>场景识别")]
        public static string Vision_Scener()
        {
            return "";
        }

        [Description("图片识别>场景识别")]
        public static string Vision_Objectr()
        {
            return "";
        }

        [Description("敏感信息审核>图片鉴黄")]
        public static string Vision_Porn()
        {
            return "";
        }
    }
}