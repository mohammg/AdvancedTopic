using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Delegate
{
    class DelegateTopic : ICommandTopic
    {
       
        public void Excute()
        {
            Persson.FormatPerson del = new Persson.FormatPerson(FormattingPers.FirstName);
            Persson p = new Persson() {FirstName="Ahemd" ,LastName= "Mahmoud",Adress="Egypt" };
            del += FormattingPers.LastName;
            // string s= del.Invoke(p);
            Console.WriteLine(  p.ToString(del));
            Console.WriteLine(p.ToString(FormattingPers.FullName));


            Cook c = new Cook();
            PizzaStep pizzaStep = new PizzaStep();
            Action step = pizzaStep.AddMaterial;
            step += pizzaStep.Heat;
            step += pizzaStep.AddChease;
            c.cook(step);
        }
    }
}
