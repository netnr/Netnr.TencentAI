namespace Netnr.TencentAI.Test
{
    public class Aai
    {
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