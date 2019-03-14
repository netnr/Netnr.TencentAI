using Netnr.TencentAI.Model;
using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    [Description("人脸与人体识别")]
    public class Face
    {
        [Description("人脸检测与分析")]
        public static string Face_DetectFace(Face_DetectFaceRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/face/face_detectface";
            return Aid.Request(request, uri);
        }

        [Description("多人脸检测")]
        public static string Face_DetectMultiFace()
        {
            return "";
        }

        [Description("跨年龄人脸识别")]
        public static string Face_DetectCrossAgeFace()
        {
            return "";
        }

        [Description("五官定位")]
        public static string Face_FaceShape()
        {
            return "";
        }

        [Description("人脸对比")]
        public static string Face_FaceCompare()
        {
            return "";
        }

        [Description("人脸搜索")]
        public static string Face_FaceIdentify()
        {
            return "";
        }

        [Description("人脸搜索>个体创建")]
        public static string Face_NewPerson()
        {
            return "";
        }

        [Description("人脸搜索>删除个体")]
        public static string Face_DelPerson()
        {
            return "";
        }

        [Description("人脸搜索>增加人脸")]
        public static string Face_AddFace()
        {
            return "";
        }

        [Description("人脸搜索>删除人脸")]
        public static string Face_DelFace()
        {
            return "";
        }

        [Description("人脸搜索>设置信息")]
        public static string Face_SetInfo()
        {
            return "";
        }

        [Description("人脸搜索>获取信息")]
        public static string Face_GetInfo()
        {
            return "";
        }

        [Description("人脸搜索>获取组列表")]
        public static string Face_GetGroupIds()
        {
            return "";
        }

        [Description("人脸搜索>获取个体列表")]
        public static string Face_GetPersonIds()
        {
            return "";
        }

        [Description("人脸搜索>获取人脸列表")]
        public static string Face_GetFaceIds()
        {
            return "";
        }

        [Description("人脸搜索>获取人脸信息")]
        public static string Face_GetFaceInfo()
        {
            return "";
        }

        [Description("人脸验证")]
        public static string Face_FaceVerify()
        {
            return "";
        }
    }
}