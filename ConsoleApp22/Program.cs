
class Program
{
  
    public static void Met1() 
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(1);
        }
    }
   public static void Met2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(2);
        }
    }
    public static void Met3()
    {
        for( int i = 0; i < 10; i++)
        {
            Task.Delay(3000);
            Console.WriteLine(3);
        }
    }
    public static void Met4()
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Delay(2000);
            Console.WriteLine(4);
        }
    }
    public static void Met5()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(500);
            Console.WriteLine(5);
        }
    }
    public static void Met6()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(700);
            Console.WriteLine(6);
        }
    }
    public static async void Met7() 
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(7);
            await Task.Delay(100);
        }
    }
    public static async void Met8()
    {
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(300);
            Console.WriteLine(8);
        }
    }


    static void Main(string[] args)
    {
       
    }
}
