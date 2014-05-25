using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Singleton
{
    /*
    DesignPatternsDemo.Singleton.PersonB personB1 = DesignPatternsDemo.Singleton.PersonB.GetInstance();
    DesignPatternsDemo.Singleton.PersonB personB2 = DesignPatternsDemo.Singleton.PersonB.GetInstance();

    if (personB1 == personB2)
    {
        Console.WriteLine("Singleton：personB1 == personB2.");
    }

    Console.ReadKey();
     */

    /// <summary>
    /// sealed阻止发生派生，而派生可能会增加实例
    /// </summary>
    public sealed class PersonB
    {
        //在第一次引用类的任何成员时创建实例。公共语言运行库负责处理变量初始化。
        private static readonly PersonB instance = new PersonB();

        private PersonB()
        {

        }

        public static PersonB GetInstance()
        {
            return instance;
        }
    }
}
