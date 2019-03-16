using Netnr.TencentAI.Model;
using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    [Description("图片特效")]
    public class Ptu
    {
        [Description("图片滤镜（天天P图）,更适合人物图片")]
        public static string Ptu_ImgFilter(Ptu_ImgFilterRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ptu/ptu_imgfilter";
            return Aid.Request(request, uri);
        }

        [Description("人脸美妆")]
        public static string Ptu_FaceCosmetic(Ptu_FaceCosmeticRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ptu/ptu_facecosmetic";
            return Aid.Request(request, uri);
        }

        [Description("人脸变妆")]
        public static string Ptu_FaceDecoration(Ptu_FaceDecorationRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ptu/ptu_facedecoration";
            return Aid.Request(request, uri);
        }

        [Description("大头贴")]
        public static string Ptu_FaceSticker(Ptu_FaceStickerRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ptu/ptu_facesticker";
            return Aid.Request(request, uri);
        }

        [Description("颜龄检测")]
        public static string Ptu_FaceAge(Ptu_FaceAgeRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/ptu/ptu_faceage";
            return Aid.Request(request, uri);
        }
    }
}
