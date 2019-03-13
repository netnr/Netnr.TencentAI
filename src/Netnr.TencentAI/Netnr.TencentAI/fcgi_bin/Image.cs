using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    public class Image
    {
        [Description("图片识别>多标签识别")]
        public static string Image_Tag()
        {
            return "";
        }

        [Description("图片识别>模糊图片检测")]
        public static string Image_Fuzzy()
        {
            return "";
        }

        [Description("图片识别>美食图片识别")]
        public static string Image_Food()
        {
            return "";
        }

        [Description("敏感信息审核>暴恐识别")]
        public static string Image_Terrorism()
        {
            return "";
        }
    }
}
