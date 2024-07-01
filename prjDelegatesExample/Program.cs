namespace prjDelegatesExample
{
    public delegate void CalculateDelegate(int no1, int no2);//these are the data types that are used within. Void and parameters all match
    public delegate int IntDelegate();//is gloabl so tha tother classes have access to the delegate as well/
    internal class Program
    {
        public static int WhatWhat()
        {
            return 0;
        }

        public static void CalcSum(int no1, int no2)
        {
            Console.WriteLine("Sum is :"+(no1+no2));
        }

        public static void CalcProd(int no1, int no2)
        {
            Console.WriteLine("prodyct is :" +(no1*no2));
        }

        public static void CalcSub(int no1, int no2)
        {
            Console.WriteLine("Sub is : "+(no1-no2));
        }
        static void Main(string[] args)
        {
            CalculateDelegate del = new CalculateDelegate(CalcSum); //assigning a whole method to an object. Can have any method that has the same signature as the delegate
            if (6 < 16)//just shows that by changing the condition, the code is run even without us running ht eapplicaiotn. (The 'greyed/dulled' code) 
            {
                del += CalcSum; //del will always be using the values 10,20
                del -= CalcSum;
            }
            else
            {
                del += CalcProd;
            }
            del += CalcSub;//del=del+CalcSum --> (10,20) must be subtracted
            del(10, 20);

            IntDelegate delNotInt = new IntDelegate(WhatWhat);
            Console.WriteLine("Int value :" +delNotInt()  );
            Console.WriteLine(""); //The console write that is inside the method is shown. And the 'new' coded use of the delegate is shown too.
        }
    }
}
