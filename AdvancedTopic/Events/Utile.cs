using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Events
{
    class CustomEventArg<T>:EventArgs
    {
        public T Person { get; set; }

    }
    class EventTest
    {
     public   delegate void AddDelegete(person person);
       public event AddDelegete OnAdd;

        public event EventHandler<CustomEventArg<person>> OnEdite;
        public void Add(person person)
        {
            OnAddEvent(person);
        }
        private void OnAddEvent(person person)
        {
            if (OnAdd!=null)
            {
                OnAdd(person);
            }
        }
        private void OnEditeEvent(person person)
        {
            if (OnAdd != null)
            {
                OnEdite(this, new CustomEventArg<person> { Person = person });
            }
        }
        public void Edite(person person)
        {
            OnEditeEvent(person);

        }
    }
    class person
    {
        public string FirstNme { get; set; }
        public string LastName { get; set; }
    }
}
