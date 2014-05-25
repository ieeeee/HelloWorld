using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Singleton
{
    /*
        DesignPatternsDemo.Singleton.Person personA = DesignPatternsDemo.Singleton.Person.GetInstance();
        DesignPatternsDemo.Singleton.Person personB = DesignPatternsDemo.Singleton.Person.GetInstance();

        if (personA == personB)
        {
            Console.WriteLine("Singleton：personA == personB.");
        }

        Console.ReadKey();
     */

    /// <summary>
    /// 国家领导人（只能有一个领导人）
    /// </summary>
    class Person
    {
        private static Person person;
        private static readonly object syncRoot = new object();

        private Person()
        {
            //构造方法让其private，这就堵死了外界利用new创建此类实例的可能
        }

        /// <summary>
        /// 此方法是获得本类实例的唯一全局访问点
        /// </summary>
        /// <returns></returns>
        public static Person GetInstance()
        {
            //双重锁定
            if (person == null)
            {
                lock (syncRoot)
                {
                    if (person == null)
                    {
                        //若实例不存在，则new一个新实例，否则返回以后实例
                        person = new Person();
                    }
                }
            }

            return person;
        }
    }
}
