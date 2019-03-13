using System;

namespace Netnr.TencentAI.Model
{
    /// <summary>
    /// 必填特性
    /// </summary>
    public class Required : Attribute
    {
        public string Message { get; set; }
    }
}