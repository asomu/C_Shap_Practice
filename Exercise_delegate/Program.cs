using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_delegate
{
    delegate void Mydelegate(int a);
    class Market
    {
        public event Mydelegate CustomEvent;
        public void BuySomething(int customNo)
        {
            if (customNo == 30)
            {
                CustomEvent(customNo);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomEvent += new Mydelegate(delegate (int a) { Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 담첨되셨습니다."); });
            for (int i = 0; i < 100; i+=10)
            {
                market.BuySomething(i);
            }
        }
        
        
        

    }
}
