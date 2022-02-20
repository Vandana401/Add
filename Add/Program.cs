using System;
namespace hello
{
    class Program
    {
        /*  public static void Add(int num1, int num2)
          {
              int result = num1 + num2;

              Console.WriteLine("Addition result is :"+ result);

          }
          static void Main(string[] args)
          {
              Console.WriteLine("Enter first number:");
             int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter second number:");
             int b = int.Parse(Console.ReadLine());
              Program.Add(a, b);


          }*/

        /*   public static void Sub(int num1,int num2)
           {
               int result = num1 - num2;
               Console.WriteLine("Subtraction result is:" + result);

           }
           static void Main(string[] args)
           {

               // Program.Sub(20,10);
               Console.WriteLine("enter the first number");
               int x=int.Parse(Console.ReadLine());
               Console.WriteLine("enter the second number");
               int y = int.Parse(Console.ReadLine());
               Program.Sub(x, y);
           }*/

                public int id;
               public string name;
               public int rollno;

             public void Add(int id, string name, int rollno)
             {
             this.id = id;
            this.name = name;
            this.rollno = rollno;
            Console.WriteLine("Student id is:"+  this.id);
           Console.WriteLine("Student name is : "+ this.name);   
            Console.WriteLine("Student roll no is :"+ this.rollno); 
           

        } }
        class students
         { 
            static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(1,"Vandana",32);
        
        }
        

    }
       
}
