using System;
using System.Collections.Generic;

namespace EatWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("吃什么？");
            var lst = new List<string>
            {
                "华味", 
                "点猪", 
                "点龟",
                "点多喝汤",
                "麦当劳",
                "肯德基",
                "点百度外卖",
                "点口碑", 
                "不吃", 
                "吃屎"
            };

            for (var i = 1; i <=lst.Count; i++)
            {
                Console.WriteLine("{0}.{1}",i,lst[i-1]);
            }

            Console.WriteLine();
            Console.WriteLine("任意键开始自动选");
            Console.ReadKey();

            Select:
            var random=new Random();
            var index = random.Next(0, lst.Count);

            Console.WriteLine();
            Console.WriteLine(lst[index]);
            Console.WriteLine("不满意任意键重选，满意Esc键退出");

            var key=Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                return;
            goto Select;
        }
    }
}
