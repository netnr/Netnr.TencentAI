using Netnr.TencentAI.Model;
using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    public class Aai
    {
        [Description("敏感信息审核>音频鉴黄/敏感词检测")]
        public static string Aai_EvilAudio()
        {
            return "";
        }

        [Description("语音识别>语音识别-echo版")]
        public static string Aai_Asr()
        {
            return "";
        }

        [Description("语音识别>语音识别-流式版（AI Lab）")]
        public static string Aai_Asrs()
        {
            return "";
        }

        [Description("语音识别>流式版(WeChat AI)")]
        public static string Aai_WxAsrs()
        {
            return "";
        }

        [Description("语音识别>长语音识别")]
        public static string Aai_WxAsrLong()
        {
            return "";
        }

        [Description("语音识别>关键词检索")]
        public static string Aai_DetectKeyWord()
        {
            return "";
        }

        [Description("语音合成>语音合成（AI Lab）")]
        public static string Aai_Tts(Aai_TtsRequest request)
        {
            if (Aid.IsValid(request))
            {
                var uri = "https://api.ai.qq.com/fcgi-bin/aai/aai_tts";
                var result = HttpTo.Get(uri + "?" + Aid.Parameter(request));
                return result;
            }
            return Aid.ValidFail();
        }

        [Description("语音合成>语音合成（优图）")]
        public static string Aai_Tta(Aai_TtaRequest request)
        {
            if (Aid.IsValid(request))
            {
                var uri = "https://api.ai.qq.com/fcgi-bin/aai/aai_tta";
                var result = HttpTo.Get(uri + "?" + Aid.Parameter(request));
                return result;
            }
            return Aid.ValidFail();
        }
    }
}