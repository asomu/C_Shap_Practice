using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step1. delegate 선언한다.
//Step2. 클래스 내에 선언한 대리자의 인스턴스를 event 키워드로 수식해서 선언한다.
//Step3. 이벤트 핸들러를 작성한다.
//Step4. 클래스의 인스턴스를 생성하고 이 객체의 이벤트에 이벤트핸들러를 등록한다.
//Step5. 이벤트가 발생하면 이벤트 핸들러가 호출된다.

//0에서 30의 수중 짝수가 나오면 message를 출력한다. 이벤트는 짝수...if 짝수 -> 이벤트 호출.


//class 필드에 delegate를 가지고 있고 그 안의 method에서 대리자를 호출한다. main에서 대리자에 이벤트를 등록하고
//class 인스턴스에서 그 method를 호출한다. 그 method에서 대리자를 호출하니 등록한게 불린다.

namespace delegate_event
{
    delegate void EventHandler(string message);

    class MyNotifiier
    {
        //대리자의 인스턴스...그러니까 event니까 이벤트 인스턴스의 이름은 SomethingHappened!
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if(temp != 0 && temp % 3 ==0)
            {
                //delegate instance에 메세지를 넣는다. 그러나 안에 method는 없는 상태.
                SomethingHappened(string.Format("{0} : 짝", number));
            }
        }
    }

    class Program
    {
        //핸들러일이 단순하게 메세지를 뿌리는것... 하나 더 등록해보자.
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static public void YourHandler(string message)
        {
            Console.WriteLine($"this is your handler :{message}");
        }

        static void Main(string[] args)
        {
            MyNotifiier notifiier = new MyNotifiier();
            notifiier.SomethingHappened += new EventHandler(MyHandler);
            // 등록하는 방법은 몇가지 있나?
            notifiier.SomethingHappened += new EventHandler(YourHandler);
            for (int i = 0; i < 30; i++)
            {
                notifiier.DoSomething(i);
            }
        }
    }
}
