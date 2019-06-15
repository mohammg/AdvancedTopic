using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public enum TopicEnum
    {
        Generic,
        Delegate,
        Events


    }
    public class Topic
    {
        Dictionary<TopicEnum, ICommandTopic> lists = new Dictionary<TopicEnum, ICommandTopic>();
        public Topic()
        {
            //class Must inherit from ICommand interface
            //add class to list To use it
            lists.Add(TopicEnum.Generic, new Generic.GenericTopic());
            lists.Add(TopicEnum.Delegate, new Delegate.DelegateTopic());
            lists.Add(TopicEnum.Events, new Events.EventsTopic());

        }
        public void DoIt(TopicEnum d)
        {
            ICommandTopic result = null;
            lists.TryGetValue(d, out result);
            if (result != null)
            {
                
                    result.Excute();
                
                
            }
            else
            {
                Console.WriteLine("Not Impelment Exm Code");
            }
        }
    }
    public interface ICommandTopic
    {
        //you enter prams in code
        void Excute();
        //you enter prams from console
       
    }
    
}
