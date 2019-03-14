namespace Netnr.TencentAI.Test
{
    public class Nlp
    {
        /// <summary>
        /// 智能闲聊 > 智能闲聊
        /// </summary>
        /// <returns></returns>
        public static string Nlp_TextChat()
        {
            var mo = new Model.Nlp_TextChatRequest
            {
                session = "netnr",
                question = "今天重庆天气怎么样"
            };

            var result = fcgi_bin.Nlp.Nlp_TextChat(mo);
            return result;
        }

        /// <summary>
        /// 机器翻译>文本翻译（AI Lab）
        /// </summary>
        /// <returns></returns>
        public static string Nlp_TextTrans()
        {
            var mo = new Model.Nlp_TextTransRequest
            {
                text = "你好，我是netnr",
                type = 0
            };

            var result = fcgi_bin.Nlp.Nlp_TextTrans(mo);
            return result;
        }

        /// <summary>
        /// 机器翻译>文本翻译（翻译君）
        /// </summary>
        /// <returns></returns>
        public static string Nlp_TextTranslate()
        {
            var mo = new Model.Nlp_TextTranslateRequest
            {
                text = "你好，我是netnr",
                source = "zh",
                target = "en"
            };

            var result = fcgi_bin.Nlp.Nlp_TextTranslate(mo);
            return result;
        }
    }
}