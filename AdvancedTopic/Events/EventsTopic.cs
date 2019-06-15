using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Events
{
    class EventsTopic : ICommandTopic
    {
        public void Excute()
        {
            EventTest eventTest = new EventTest();
            person person = new person { FirstNme = "Mohamed", LastName = "Said" };
            eventTest.OnAdd += EventTest_OnAdd;
            eventTest.OnEdite += EventTest_OnEdite;
            eventTest.Add(person);
            eventTest.Edite(person);
        }

        private void EventTest_OnEdite(object sender, CustomEventArg<person> e)
        {
            Console.WriteLine($"Edite : {e.Person.FirstNme}");
        }

        private void EventTest_OnAdd(person person)
        {
            Console.WriteLine(person.FirstNme);
        }
    }
}
