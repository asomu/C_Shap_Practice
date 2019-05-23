using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MainPractice
{

    /* 1. overriding polymorphism
     * 2. sealed
     * 3. virtual
     * 4. private
     * 5. base / this
     */

    class Mammal
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int paw;
        public int Paw
        {
            get { return paw; }
            set { paw = value; }
        }

        virtual public  void mew()
        {
            Console.WriteLine("Wooooo!");
        }
        public void fly()
        {
            Console.WriteLine("Fly~~~~");
        }
        public Mammal()
        {
            age = 23;
        }
        public Mammal(int weight):this()
        {
            this.weight = weight;
        }
        public Mammal(int weight, int paw):this(weight)            
        {
            this.paw = paw;
        }
    }
    
    class Cat:Mammal
    {
        public override void mew()
        {
            Console.WriteLine("mewmewmew!!!");
        }
    }
    class Dog:Mammal
    {
        //new로 선언한건 객체 타입의 메서드가 불린다. base에 자식을 넣으면 base 메서드가 불린다.
        new public void mew()
        {
            Console.WriteLine("bowwow!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var navi = new Cat();
            navi.mew();
            Mammal mal = new Cat();
            mal.mew();
            Mammal mal_ori = new Mammal();
            mal_ori.mew();

            //override가 되지 않아서 그런지 base가 불린다. puppy는 base이다.
            Mammal puppy = new Dog();
            puppy.mew();

            //happy는 dog 이므로 dog 메서드가 불린다.
            var happy = new Dog();
            happy.mew();

            Console.WriteLine("====================================");

            var mals = new List<Mammal>();
            mals.Add(navi);
            mals.Add(mal);
            mals.Add(mal_ori);
            mals.Add(puppy);
            mals.Add(happy);

            //mewmewmew!!!
            //mewmewmew!!!
            //Wooooo!
            //Wooooo!
            //Wooooo!

            foreach(Mammal mamm in mals)
            {
                mamm.mew();
            }
            //중요한 것은 generic에 base로 선언하여 자식들을 넣고 부르면 자식의 메서드가 불린다.
            //Base에 부모로 선언하여 넣고 자식들을 종류별로 넣고 각각의 메서드를 부를 수 있다는 것인다.

            //sealed 사용하기
            navi.fly();

            //생성자.
            Mammal maly = new Mammal(50);
            Console.WriteLine(@"{0}  {1}", maly.Age, maly.Weight);
            
            Mammal maly2 = new Mammal();
            Console.WriteLine(@"{0}  {1}", maly2.Age, maly2.Weight);

            Mammal maly3 = new Mammal(20, 888);
            Console.WriteLine(@"{0}  {1}  {2}", maly3.Age, maly3.Weight, maly3.Paw);
        }
    }
}
