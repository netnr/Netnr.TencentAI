namespace Netnr.TencentAI.Test
{
    public class Aai
    {
        /// <summary>
        /// 敏感信息审核>音频鉴黄/敏感词检测
        /// </summary>
        /// <returns></returns>
        public static string Aai_EvilAudio()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音识别>语音识别-echo版
        /// </summary>
        /// <returns></returns>
        public static string Aai_Asr()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音识别>语音识别-流式版（AI Lab）
        /// </summary>
        /// <returns></returns>
        public static string Aai_Asrs()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音识别>流式版(WeChat AI)
        /// </summary>
        /// <returns></returns>
        public static string Aai_WxAsrs()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音识别>长语音识别
        /// </summary>
        /// <returns></returns>
        public static string Aai_WxAsrLong()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音识别>关键词检索
        /// </summary>
        /// <returns></returns>
        public static string Aai_DetectKeyWord()
        {
            return "待测试";
        }

        /// <summary>
        /// 语音合成>语音合成（AI Lab）
        /// </summary>
        /// <returns></returns>
        public static string Aai_Tts()
        {
            var mo = new Model.Aai_TtsRequest
            {
                text = "Hi，我是netnr"
            };

            var result = fcgi_bin.Aai.Aai_Tts(mo);
            return result;
        }

        /// <summary>
        /// 语音合成>语音合成（优图）
        /// </summary>
        /// <returns></returns>
        public static string Aai_Tta()
        {
            var mo = new Model.Aai_TtaRequest
            {
                text = "Hi，我是netnr"
            };

            var result = fcgi_bin.Aai.Aai_Tta(mo);
            return result;
        }
    }
}