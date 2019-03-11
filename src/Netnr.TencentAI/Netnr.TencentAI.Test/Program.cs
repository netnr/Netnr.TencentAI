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
            var msg = GetMethodInfo();
            Console.WriteLine(msg);

            Console.ReadLine();
        }

        /// <summary>
        /// 反射得到方法列表，JSON格式
        /// </summary>
        /// <returns></returns>
        public static string GetMethodInfo()
        {
            var dicClass = new Dictionary<string, string>();
            var dicMethod = new Dictionary<string, string>();

            var ns = "Netnr.TencentAi";
            Assembly asm = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + $"/{ns}.dll");
            foreach (var dt in asm.DefinedTypes)
            {
                if (dt.FullName.Contains(ns))
                {
                    Type t = asm.GetType($"{ns}.fcgi_bin.{dt.Name}");
                    var attrClass = Attribute.GetCustomAttribute(t, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    dicClass.Add(dt.Name, attrClass?.Description ?? "");

                    var mhs = t.GetMethods();
                    foreach (var mh in mhs)
                    {
                        var attrMethod = Attribute.GetCustomAttribute(mh, typeof(DescriptionAttribute)) as DescriptionAttribute;
                        if (attrMethod != null)
                        {
                            dicMethod.Add(mh.Name, attrMethod.Description);
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
