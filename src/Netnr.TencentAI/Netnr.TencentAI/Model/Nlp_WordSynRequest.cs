﻿namespace Netnr.TencentAI.Model
{
    /// <summary>
    /// 基础文本分析>同义词
    /// </summary>
    public class Nlp_WordSynRequest : BaseRequest
    {
        /// <summary>
        /// GBK编码，非空且长度上限1024字节
        /// </summary>
        [Required]
        public string text { get; set; }
    }
}