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

        /// <summary>
        /// 基础文本分析>分词
        /// </summary>
        /// <returns></returns>
        public static string Nlp_WordSeg()
        {
            var mo = new Model.Nlp_WordSegRequest
            {
                text = "你好，我是netnr，一个热爱前端的后台程序员"
            };

            var result = fcgi_bin.Nlp.Nlp_WordSeg(mo);
            return result;
        }

        /// <summary>
        /// 基础文本分析>词性
        /// </summary>
        /// <returns></returns>
        public static string Nlp_WordPos()
        {
            var mo = new Model.Nlp_WordPosRequest
            {
                text = "你好，我是netnr，一个热爱前端的后台程序员"
            };

            var result = fcgi_bin.Nlp.Nlp_WordPos(mo);
            return result;
        }

        /// <summary>
        /// 基础文本分析>专有名词
        /// </summary>
        /// <returns></returns>
        public static string Nlp_WordNer()
        {
            var mo = new Model.Nlp_WordNerRequest
            {
                text = "3月23日消息，腾讯宣布任命人工智能领域顶尖科学家张潼担任腾讯人工智能实验室主任，主持包括计算机视觉、语音识别、自然语言处理和机器学习等人工智能领域的基础研究。"
            };

            var result = fcgi_bin.Nlp.Nlp_WordNer(mo);
            return result;
        }

        /// <summary>
        /// 基础文本分析>同义词
        /// </summary>
        /// <returns></returns>
        public static string Nlp_WordSyn()
        {
            var mo = new Model.Nlp_WordSynRequest
            {
                text = "今天的天气怎么样"
            };

            var result = fcgi_bin.Nlp.Nlp_WordSyn(mo);
            return result;
        }

        /// <summary>
        /// 语义解析>意图成分
        /// </summary>
        /// <returns></returns>
        public static string Nlp_WordCom()
        {
            var mo = new Model.Nlp_WordComRequest
            {
                text = "最近有什么科技新闻？"
            };

            var result = fcgi_bin.Nlp.Nlp_WordCom(mo);
            return result;
        }

        /// <summary>
        /// 语义解析>情感分析
        /// </summary>
        /// <returns></returns>
        public static string Nlp_TextPolar()
        {
            var mo = new Model.Nlp_TextPolarRequest
            {
                text = "看完这部电影，几次被戳中泪点，心里很不舒服。"
            };

            var result = fcgi_bin.Nlp.Nlp_TextPolar(mo);
            return result;
        }
    }
}