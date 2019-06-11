using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Chain
{
    class Program
    {
        //delegate 선언....
        delegate void Notify(string message);

        //Notifier delegate를 가지고 있는 class. 그 이름은 EventOccured
        class Notifier
        {
            public Notify EventOccured;
        }

        class EventListener
        {
            private string name;
            public EventListener(string name)
            {
                this.name = name;
            }
            //delegate에 넣을 수 있는 method다.... 이것을 넣어야 한다. EventOccured에다가
            public void SomethingHappened(string message)
            {
                Console.WriteLine($"{name}.SomethingHappened : {message}");
            }


        }
        static void Main(string[] args)
        {
            //delegate를 가지고 있는 class notifier instance 생성
            Notifier notifier = new Notifier();
            //event listener class instance 1,2,3 생성.
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            //EventOvvured delegate에다가 method를 집어 넣는다.
            notifier.EventOccured += listener1.SomethingHappened;
            notifier.EventOccured += listener2.SomethingHappened;
            notifier.EventOccured += listener3.SomethingHappened;
            //Delegate를 사용하여 delegate chain 3개를 한번에 부른다.
            //EvnetOccured안에 method 3개 준비되어 있고
            //parameter string "You've got mail"을 넣는 순간 3개의 method를 모두 부른다.
            notifier.EventOccured("You've got mail");

            Console.WriteLine();

            //하나의 chain을 뺐다.
            notifier.EventOccured -= listener2.SomethingHappened;
            notifier.EventOccured("Download complete");

            Console.WriteLine();

            //2와 3만 다시 집어 넣었다.
            notifier.EventOccured = new Notify(listener2.SomethingHappened) + new Notify(listener3.SomethingHappened);
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();


            Notify notify1 = new Notify(listener1.SomethingHappened);
            Notify notify2 = new Notify(listener2.SomethingHappened);

            notifier.EventOccured = 
                (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            notifier.EventOccured =
                (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!");


        }
    }
}
