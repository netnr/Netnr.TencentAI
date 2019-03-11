using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Netnr.TencentAi.fcgi_bin
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

        [Description("语音识别>语音识别-流式版（AI Lab")]
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
        public static string Aai_Tts()
        {
            return "";
        }

        [Description("语音合成>语音合成（优图）")]
        public static string Aai_Tta()
        {
            return "";
        }
    }
}