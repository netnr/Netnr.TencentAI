using System.IO;
using System.Net;
using System.Text;

namespace Netnr.TencentAI
{
    /// <summary>
    /// HTTP请求
    /// </summary>
    public class HttpTo
    {
        #region 服务器 发送请求
        /// <summary>
        /// 发送请求参数设置
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="type">请求类型 默认GET </param>
        /// <param name="postData">POST发送内容 默认空</param>
        /// <param name="charset">编码</param>
        /// <returns></returns>
        public static HttpWebRequest HWRequest(string url, string type = "GET", string postData = "", string charset = "utf-8")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = type;
            request.KeepAlive = true;
            request.AllowAutoRedirect = true;
            request.MaximumAutomaticRedirections = 4;
            request.Timeout = short.MaxValue * 3;//MS
            request.ContentType = "application/x-www-form-urlencoded";

            if (type != "GET")
            {
                //发送内容
                byte[] bytes = Encoding.GetEncoding(charset).GetBytes(postData);
                request.ContentLength = Encoding.GetEncoding(charset).GetBytes(postData).Length;
                Stream outputStream = request.GetRequestStream();
                outputStream.Write(bytes, 0, bytes.Length);
                outputStream.Close();
            }
            return request;
        }

        /// <summary>
        /// 发送请求 得到请求结果
        /// </summary>
        /// <param name="request">HttpWebRequest对象 可通过HWRequest方法创建</param>
        /// <param name="e">返回类容编码 默认UTF-8</param>
        /// <returns></returns>
        public static string Url(HttpWebRequest request, Encoding e)
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            if (string.Compare(response.ContentEncoding, "gzip", true) >= 0)
                responseStream = new System.IO.Compression.GZipStream(responseStream, System.IO.Compression.CompressionMode.Decompress);
            StreamReader reader = new StreamReader(responseStream, e);
            string result = "", strData = "";
            //result = reader.ReadToEnd();
            while ((strData = reader.ReadLine()) != null)
            {
                result += strData + "\r\n";
            }
            reader.Close();
            responseStream.Close();
            return result;
        }

        /// <summary>
        /// 发送请求 得到请求结果
        /// </summary>
        /// <param name="request">HttpWebRequest对象 可通过HWRequest方法创建</param>
        /// <param name="charset">编码</param>
        /// <returns></returns>
        public static string Url(HttpWebRequest request, string charset = "utf-8")
        {
            return Url(request, Encoding.GetEncoding(charset));
        }

        /// <summary>
        /// 发送 GET 请求 得到请求结果
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="charset">编码</param>
        /// <returns></returns>
        public static string Get(string url, string charset = "utf-8")
        {
            return Url(HWRequest(url, "GET", null, charset), Encoding.GetEncoding(charset));
        }

        /// <summary>
        /// 发送 POST 请求
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="postData">发送内容</param>
        /// <param name="charset">编码</param>
        /// <returns></returns>
        public static string Post(string url, string postData, string charset = "utf-8")
        {
            return Url(HWRequest(url, "POST", postData, charset));
        }
        #endregion
    }
}