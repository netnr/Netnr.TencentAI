using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Netnr.TencentAI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //所有方法
            var msg = GetMethodInfo();
            Console.WriteLine(msg);

            //示例
            Aid.APPID = 2112919356;
            Aid.APPKEY = "Vqe3e9EBzi0r5wJK";

            var result = string.Empty;

            //result = Nlp.Nlp_TextPolar();

            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// 反射得到方法列表，JSON格式
        /// </summary>
        /// <returns></returns>
        public static string GetMethodInfo()
        {
            var dicClass = new Dictionary<string, string>();
            var dicMethod = new Dictionary<string, string>();

            var ns = "Netnr.TencentAI";
            var nssub = "fcgi_bin";

            Assembly asm = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + $"/{ns}.dll");
            foreach (var dt in asm.DefinedTypes)
            {
                if (dt.FullName.Contains(ns) && dt.FullName.Contains(nssub))
                {
                    Type t = asm.GetType($"{ns}.{nssub}.{dt.Name}");
                    var attrClass = Attribute.GetCustomAttribute(t, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    dicClass.Add(dt.Name, attrClass?.Description ?? "");

                    var mhs = t.GetMethods();
                    foreach (var mh in mhs)
                    {
                        var attrMethod = Attribute.GetCustomAttribute(mh, typeof(DescriptionAttribute)) as DescriptionAttribute;
                        if (attrMethod != null)
                        {
                            var isc = string.Empty;
                            if (mh.ToString().Contains(ns))
                            {
                                isc = "【√】";
                            }
                            dicMethod.Add(mh.Name, attrMethod.Description + isc);
                        }
                    }
                }
            }
            var listKey = dicMethod.Keys.ToList();

            var dic = new Dictionary<string, Dictionary<string, string>>();

            foreach (var methodKey in listKey)
            {
                var key = methodKey.Split('_')[0];
                var classDesc = dicClass[key];
                var desc = dicMethod[methodKey];
                if (!string.IsNullOrWhiteSpace(classDesc))
                {
                    desc = classDesc + ">" + desc;
                    dicMethod[methodKey] = desc;
                }

                var dcs = desc.Split('>').ToList();
                var dcskey = dcs[0];
                dcs.RemoveAt(0);
                var dcsval = string.Join(" > ", dcs);

                if (dic.ContainsKey(dcskey))
                {
                    dic[dcskey].Add(methodKey, dcsval);
                }
                else
                {
                    var dicitem = new Dictionary<string, string>
                    {
                        { methodKey, dcsval }
                    };
                    dic[dcskey] = dicitem;
                }
            }

            return dic.ToJson();
        }
    }
}