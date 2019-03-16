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
            var mo = new Model.Aai_EvilAudioRequest
            {
                speech_url = "http://fjdx.sc.chinaz.com/Files/DownLoad/sound1/201811/10786.mp3"
            };
            var result = fcgi_bin.Aai.Aai_EvilAudio();
            return result;
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