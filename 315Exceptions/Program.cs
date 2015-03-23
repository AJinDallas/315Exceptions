using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _315Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Rick", "James");
            Person.count = 2;
            Person.updateCount(100);

            String currName = p1.UserName;
            //Console.WriteLine(currName);
            Person Rj = new Person("R", "J");
            //Rj.greeting();
            Console.WriteLine(Rj.salutation());
            Hero h1 = new Hero("John", "Wayne", "Gun sling'n");
            Console.WriteLine(h1.salutation());

            //Person.count = 54;

            //h1.greeting();
            Console.WriteLine(h1.salutation());
            Console.ReadLine();
        }
    }
    // Audit Class
    public abstract class Audit
    {
        public abstract String salutation(); 
      
        public DateTime timeCreated { get; set; }
        public virtual void sayName() {
            Console.WriteLine("hello from BASE");
        }
        public abstract void greeting();
       
    }

    // Person Class
    public class Person : Audit
    {

        public static int count { get; set; }
        public static void updateCount(int nVal)
        {
            Console.WriteLine(nVal);
            Person.count = nVal;
        }

        public override string salutation()
        {
            return "dear" + this.FirstName + " " + this.LastName;
        }
        public override void greeting()
        {
            Console.WriteLine("bon jour");

        }
        /**/
        public override void sayName()
        {
            Console.WriteLine("hello from PERSON");
            //base.sayName();
        }
        public string UserName
        {
            get
            {
                return fName + "_" + lName ;
            }
        }
        private string fName { get; set; }
        private string lName { get; set; }
        public string FirstName
        { 
            get {
                return fName;
            } 
            set {
                fName = value; ;
            } 
        }
        public string LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value; ;
            }
        }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

    
     class Hero : Person
    {
         public override string salutation()
         {
             return "super" + this.FirstName;
         }
         public override void greeting()
         {
             Console.WriteLine("howfy");
             //base.greeting();
         }
         /*
      public override void greeting()
        {
            Console.WriteLine("LalAAAA");
         }
          */
      public string SuperPower {get; set;}

        public Hero(string FirstName, string LastName,string SuperPower)
        :base(FirstName, LastName)
        
        {
            this.SuperPower = SuperPower;
        }
        public override void sayName()
        {
            Console.WriteLine("hello from HERO");
            base.sayName();
        }
    }

}
