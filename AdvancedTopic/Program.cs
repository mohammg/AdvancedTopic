using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic();
            topic.DoIt(TopicEnum.Generic);
            Console.WriteLine("Press Any Key To Exist........");
            Console.ReadKey();
        }
    }
}
