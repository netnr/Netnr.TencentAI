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
    }
}