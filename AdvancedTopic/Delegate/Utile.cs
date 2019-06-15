using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Delegate
{
    // add Material
    // Pre-heat 
    // putt cheese
    // 
    public class Cook
    {
        public void cook(Action action)
        {
            action.Invoke();
        }
    }
    public class PizzaStep
    {
        public void AddMaterial()
        {
            Console.WriteLine("Add material");
        }
        public void Heat()
        {
            Console.WriteLine("On Heat");
        }
        public void AddChease()
        {
            Console.WriteLine("Chease");
        }
    }

    public class Persson
    {
        public delegate string FormatPerson(Persson persson);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Rate { get; set; }
        
        public string ToString(FormatPerson format)
        {
            return format(this);
        }
        public void ToString(Action<Persson> person)
        {
            person(this);
           
        }


    }

    public class FormattingPers
    {
        public static string FirstName(Persson persson)
        {
            return persson.FirstName;
        }
        public static string LastName(Persson persson)
        {
            return persson.LastName;
        }
        public static string NameRating(Persson persson)
        {
            return persson.FirstName + persson.Rate;
        }
        public static string FullName(Persson persson)
        {
            return string.Format("{0},{1}", persson.FirstName, persson.LastName);
        }
    }
}
