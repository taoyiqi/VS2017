using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml;

namespace MyIocTest.Models
{
    public class IocContainer : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            /*
              * 获取需要注入的类的相关信息
              */
            NameValueCollection paramCollection = (NameValueCollection)new NameValueSectionHandler().Create(parent, configContext, section);
            //获取类名
            string className = IocDomain.className;
            string classInfo = paramCollection[className].ToString();
            //获取全类名
            string classFullName = classInfo.Split(',')[0];
            //获取程序集名称
            string assemblyName = classInfo.Split(',')[1];

            /*
             * 根据反射，取得对象
             */
            Assembly assembly = Assembly.Load(assemblyName);
            Type t = assembly.GetType(classFullName);
            Object obj = Activator.CreateInstance(t);
            return obj;
        }
    }
}