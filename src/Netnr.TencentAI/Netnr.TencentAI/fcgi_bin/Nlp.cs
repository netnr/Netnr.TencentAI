using Netnr.TencentAI.Model;
using System.ComponentModel;

namespace Netnr.TencentAI.fcgi_bin
{
    public class Nlp
    {
        [Description("智能闲聊>智能闲聊")]
        public static string Nlp_TextChat(Nlp_TextChatRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_textchat";
            return Aid.Request(request, uri, "GET");
        }

        [Description("机器翻译>文本翻译（AI Lab）")]
        public static string Nlp_TextTrans(Nlp_TextTransRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_texttrans";
            return Aid.Request(request, uri, "GET");
        }

        [Description("机器翻译>文本翻译（翻译君）")]
        public static string Nlp_TextTranslate(Nlp_TextTranslateRequest request)
        {
            var uri = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_texttranslate";
            return Aid.Request(request, uri, "GET");
        }

        [Description("机器翻译>语音翻译")]
        public static string Nlp_SpeechTranslate()
        {
            return "";
        }

        [Description("机器翻译>机器翻译")]
        public static string Nlp_ImageTranslate()
        {
            return "";
        }

        [Description("机器翻译>语种识别")]
        public static string Nlp_TextDetect()
        {
            return "";
        }

        [Description("基础文本分析>分词")]
        public static string Nlp_WordSeg()
        {
            return "";
        }

        [Description("基础文本分析>词性")]
        public static string Nlp_WordPos()
        {
            return "";
        }

        [Description("基础文本分析>专有名词")]
        public static string Nlp_WordNer()
        {
            return "";
        }

        [Description("基础文本分析>同义词")]
        public static string Nlp_WordSyn()
        {
            return "";
        }

        [Description("语义解析>意图成分")]
        public static string Nlp_WordCom()
        {
            return "";
        }

        [Description("语义解析>情感分析")]
        public static string Nlp_TextPolar()
        {
            return "";
        }
    }
}