using System.Threading.Channels;

namespace homework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FirstTask.Money test = new FirstTask.Money();
            test.integer = 10;
            Console.WriteLine(test);
            test.fractional = 99;
            Console.WriteLine(test);
            FirstTask.Product product = new FirstTask.Product();
            product.NameOfProduct = "chese";
            product.integer = test.integer;
            product.fractional = test.fractional;
            Console.WriteLine(product);
        }

    }
    namespace FirstTask
    {
        /*Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
В классе должны быть предусмотрены поле для хранения целой части денег(доллары, евро,гривны и т.д.) и поле 
для хранения копеек (центы, евроценты, копейки и т.д.).
Реализовать методы для вывода суммы на экран, задания значений для частей. 
На базе класса Money создать класс Product для работы 
с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
Для каждого из классов реализовать необходимые 
методы и поля*/
        class Money
        {
            string name;
            public int integer { get; set; }
            public int fractional { get; set; }

            public override string ToString()
            {
                return integer.ToString() + ',' + fractional.ToString();
            }
            public void Decrease(int integer, int fractional)
            {
                this.integer -= integer;
                this.fractional -= fractional;
            }
            public void Increase(int integer, int fractional)
            {
                this.integer += integer;
                this.fractional += fractional;
            }
        }
        class Product : Money
        {
            public string NameOfProduct { get; set; } = "No Name";
            public override string ToString()
            {
                return NameOfProduct + " " + base.ToString();
            }
        }
    }
    namespace SecondTask
    {
        /*Создать базовый класс «Устройство» и производные
классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого
устройства и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound — издает звук устройства (пишем текстом в
консоль);
1
■ Show — отображает название устройства;
■ Desc — отображает описание устройства.*/
        abstract class Machine
        {
            public string Name { get; set; }
            abstract public void Sound();
            abstract public void Show();
            abstract public void Desc();
        }
        class Kettle : Machine
        {
            public override void Desc()
            {
                Console.WriteLine("it is kettle");
            }

            public override void Show()
            {
                Console.WriteLine("kettle");
            }

            public override void Sound()
            {
                Console.WriteLine("ssssss");
            }
        }
        class Microwave : Machine
        {
            public override void Desc()
            {
                Console.WriteLine("make food warmer");
            }

            public override void Show()
            {
                Console.WriteLine("it is microwave");
            }

            public override void Sound()
            {
                Console.WriteLine("UUUUUU");
            }
        }
        class Car : Machine
        {
            public override void Desc()
            {
                Console.WriteLine("car to drive");
            }

            public override void Show()
            {
                Console.WriteLine("It is car");
            }

            public override void Sound()
            {
                Console.WriteLine("вжжжжжжж");
            }
        }
        class Steamboat : Machine
        {
            public override void Desc()
            {
                Console.WriteLine("boat with steam engine");
            }

            public override void Show()
            {
                Console.WriteLine("boat");
            }

            public override void Sound()
            {
                Console.WriteLine("пых пых пых");
            }
        }


    } 
    namespace ThriedTask
    {
        /*Создать базовый класс «Музыкальный инструмент» 
и производные классы «Скрипка», «Тромбон», «Укулеле», 
«Виолончель». С помощью конструктора установить имя 
каждого музыкального инструмента и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound — издает звук музыкального инструмента 
(пишем текстом в консоль);
■ Show — отображает название музыкального инструмента;
■ Desc — отображает описание музыкального инструмента;
■ History — отображает историю создания музыкального инструмента*/
        public class MusicalInstrument
        {
            public string Name { get; set; }
            public string Characteristics { get; set; }

            public MusicalInstrument(string name, string characteristics)
            {
                Name = name;
                Characteristics = characteristics;
            }

            public virtual void Sound()
            {
                Console.WriteLine("The musical instrument makes a sound.");
            }

            public virtual void Show()
            {
                Console.WriteLine("The musical instrument is called " + Name + ".");
            }

            public virtual void Desc()
            {
                Console.WriteLine("The musical instrument is " + Characteristics + ".");
            }

            public virtual void History()
            {
                Console.WriteLine("The musical instrument was created in the 16th century.");
            }
        }

        public class Violin : MusicalInstrument
        {
            public Violin(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("The violin makes a beautiful sound.");
            }

            public override void Show()
            {
                Console.WriteLine("The musical instrument is a violin.");
            }

            public override void Desc()
            {
                Console.WriteLine("The violin is a stringed instrument that is played with a bow.");
            }

            public override void History()
            {
                Console.WriteLine("The violin was created in the early 16th century in Italy.");
            }
        }

        public class Trombone : MusicalInstrument
        {
            public Trombone(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("The trombone makes a deep, rich sound.");
            }

            public override void Show()
            {
                Console.WriteLine("The musical instrument is a trombone.");
            }

            public override void Desc()
            {
                Console.WriteLine("The trombone is a brass instrument that is played by blowing into a mouthpiece and moving a slide.");
            }

            public override void History()
            {
                Console.WriteLine("The trombone was created in the 15th century in Germany.");
            }
        }

        public class Ukulele : MusicalInstrument
        {
            public Ukulele(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("The ukulele makes a bright, cheerful sound.");
            }

            public override void Show()
            {
                Console.WriteLine("The musical instrument is an ukulele.");
            }

            public override void Desc()
            {
                Console.WriteLine("The ukulele is a small, four-stringed instrument that is played by strumming or picking.");
            }

            public override void History()
            {
                Console.WriteLine("The ukulele was created in the 19th century in Hawaii.");
            }
        }

        public class Cello : MusicalInstrument
        {
            public Cello(string name, string characteristics) : base(name, characteristics)
            {
            }

            public override void Sound()
            {
                Console.WriteLine("The cello makes a warm, mellow sound.");
            }

            public override void Show()
            {
                Console.WriteLine("The musical instrument is a cello.");
            }

            public override void Desc()
            {
                Console.WriteLine("The cello is a stringed instrument that is played with a bow.");
            }

            public override void History()
            {
                Console.WriteLine("The cello was created in the early 16th century in Italy.");
            }
        }
    }
    namespace FourTask
    {
        /*Создать абстрактный базовый классWorker(работника) 
с методом Print(). Создайте четыре производных класса: 
President, Security, Manager, Engineer. Переопределите метод
Print() для вывода информации, соответствующей 
каждому типу работника*/
        abstract class Worker
        {
            public abstract void Print();
        }
        class President:Worker
        {
            public override void Print()
            {
                Console.WriteLine("Президент управляет страной");
            }

        }
        class Security:Worker
        {
            public override void Print()
            {
                Console.WriteLine("охранник охраняет");
            }
        }
        class  Manager:Worker
        {
            public override void Print()
            {
                Console.WriteLine("манагер чистит туалет");
            }
        }
        class Enginer : Worker
        {
            public override void Print()
            {
                Console.WriteLine("Инженегр что-то считает");
            }
        }
    }
}