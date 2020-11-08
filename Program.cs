using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.Iterator;
using DesignPatterns.BehavioralPatterns.Mediator;
using DesignPatterns.BehavioralPatterns.Memento;
using DesignPatterns.BehavioralPatterns.Observer;
using DesignPatterns.BehavioralPatterns.State;
using DesignPatterns.BehavioralPatterns.Strategy;
using DesignPatterns.BehavioralPatterns.TemplateMethod;
using DesignPatterns.BehavioralPatterns.Visitor;
using DesignPatterns.BuilderDesign;
using DesignPatterns.CreationalPatterns.ObjectPool;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Prototype;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Facade;
using DesignPatterns.StructuralPatterns.Flyweight;
using DesignPatterns.StructuralPatterns.Proxy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns
            //Singleton
            Singleton singleton = Singleton.GetInstance();
            singleton.someUsefulCode();

            Separate();

            //Builder
            Item ciastko = new ItemBuilder(0).SetName("Ciastko").SetType("Food").build();
            Console.WriteLine($"{ciastko.id}. {ciastko.name}, {ciastko.type}");

            Separate();

            //Prototype
            Person person = new Person(1, 15, "John");
            Person shallowCopy = (Person)person.ShallowCopy();
            Person deepCopy = (Person)person.DeepCopy();
            Console.WriteLine(person);
            Console.WriteLine(shallowCopy);
            Console.WriteLine(deepCopy);
            person.name = "Max";
            person.age = 20;
            person.id = new IdInfo(99);
            Console.WriteLine(person);
            Console.WriteLine(shallowCopy);
            Console.WriteLine(deepCopy);

            Separate();

            //AbstractFactory
            Car miniCar = CarFactory.CarBuilder(CarType.MINI);
            Car lumiCar = CarFactory.CarBuilder(CarType.LUXURY);

            Separate();

            //FactoryPattern
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape circle = shapeFactory.GetShape("circle");
            circle.print();

            Separate();

            //ObjectPool
            SomeObject so1 = Pool.GetObject();
            SomeObject so2 = Pool.GetObject();
            Pool.ReleaseObject(so1);
            SomeObject so3 = Pool.GetObject();
            Console.WriteLine($"so1: {so1}");
            Console.WriteLine($"so2: {so2}");
            Console.WriteLine($"so3: {so3}");

            Separate();

            #endregion

            #region Structural Patterns

            //Adapter
            OldClass oldClass = new OldClass();
            IWrite write = new Adapter(oldClass);
            write.PrintMessage();

            Separate();

            //Bridge
            Thing triangle = new Ball(new Blue());
            triangle.print();

            Separate();

            //Composite
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");
            Component leaf3 = new Leaf("leaf3");

            Component branch1 = new Composite("branch1");
            branch1.Add(leaf1);
            branch1.Add(leaf2);

            Component root = new Composite("root");
            root.Add(branch1);
            root.Add(leaf3);

            root.Display(1);

            Separate();

            //Decorator
            Weapon weapon = new BaseWeapon();
            weapon.shot();
            Weapon modifiedWeapon = new Stock(weapon);
            modifiedWeapon.shot();

            Separate();

            //Facade
            Student student = new Student();
            student.StartLearning();
            student.EndLearning();

            Separate();

            //Flyweight
            Particle p1 = ParticleFactory.getSmallParticle("red"); //new key
            Particle p2 = ParticleFactory.getSmallParticle("red"); //no new one
            Particle p3 = ParticleFactory.getSmallParticle("blue"); //new key

            Separate();

            //Proxy
            IBank proxyBank = new ProxyBank();
            proxyBank.Pay();

            Separate();

            #endregion

            #region Behavioral Patterns

            //ChainOfResponsibility
            Chain chain = new Chain();
            chain.Process(5);

            Separate();

            //Command
            var modifyPrice = new ModifyPrice();
            var product = new Product("Brick", 200);

            Console.WriteLine(product);
            modifyPrice.SetCommandAndInvoke(new ProductCommand(product, PriceAction.Increase, 50));
            Console.WriteLine(product);

            Separate();


            //Iterator
            CarRepository carRepository = new CarRepository(new string[] { "Renault", "BMW", "VW"});

            for(IIterator i = carRepository.GetIterator(); i.hasNext(); )
            {
                Console.WriteLine($"Car: {i.next()}");
            }

            Separate();

            //Mediator
            Mediator mediator = new RealMediator();
            APerson jhon = new RealPerson(mediator, "Jhon");
            APerson max = new RealPerson(mediator, "Max");
            APerson emma = new RealPerson(mediator, "Emma");
            mediator.AddPerson(jhon);
            mediator.AddPerson(max);
            mediator.AddPerson(emma);

            jhon.Send("I'm a jhon and this is my message! ");
            emma.Send("henlo");

            Separate();

            //Memento
            Localization localization = new Localization("NY", 123, 111);
            LocalizationSnapshot snapshot = localization.CreateSnapshot();
            Console.WriteLine(localization);

            localization.City = "Berlin";
            localization.X = 999;
            Console.WriteLine(localization);

            snapshot.Restore();
            Console.WriteLine(localization);

            Separate();

            //Observer
            Customer james = new Customer("James");
            Customer william = new Customer("William");
            Customer evelyn = new Customer("Evelyn");

            Shop grocery = new Shop("YourFood");
            Shop DIYshop = new Shop("Tooler");

            grocery.AddSubscriber(james);
            grocery.AddSubscriber(william);
            grocery.AddSubscriber(evelyn);

            DIYshop.AddSubscriber(james);
            DIYshop.AddSubscriber(william);

            grocery.AddMerchandise(new Merchandise("pizza", 19));
            DIYshop.AddMerchandise(new Merchandise("hammer", 399));

            Separate();

            //State
            AudioPlayer ap = new AudioPlayer();
            ap.ClickPlay();
            ap.ClickLock();
            ap.ClickPlay();
            ap.ClickPlay();
            ap.ClickPlay();
            ap.ClickLock();
            ap.NextSong();
            ap.PreviousSong();

            Separate();

            //Strategy
            Calculator calculator = new Calculator(new AddingStrategy());
            calculator.Calculate(5, 2);
            calculator.ChangeStrategy(new SubtractingStrategy());
            calculator.Calculate(5, 2);

            Separate();

            //TemplateMethod
            Algorithm a1 = new AlgorithmWithStep2();
            a1.Execute();
            Algorithm a2 = new AlgorithmWithStep2and3();
            a2.Execute();

            Separate();

            //Visitor
            ElementA ea = new ElementA("ElementA");
            ElementA eb = new ElementA("ElementB");
            Visitor1 v1 = new Visitor1();
            Visitor2 v2 = new Visitor2();
            ea.Accept(v1);
            ea.Accept(v2);
            eb.Accept(v1);
            eb.Accept(v2);
            #endregion
        }

        private static void Separate()
        {
            Console.Write("\n\n\n");
        }

    }
}
