namespace _3cuDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-7 arasi gunlerden birini secin");  
            int gun = Convert.ToInt32(Console.ReadLine());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("bazar ertesi");
                    break;
                    case 2:
                    Console.WriteLine("cersembe axsami");
                    break;
                    case 3:
                    Console.WriteLine("cersembe");
                    break;
                    case 4:
                    Console.WriteLine("cume axsami");
                    break;
                    case 5:
                    Console.WriteLine("cume");
                    break;
                    case 6:
                    Console.WriteLine("senbe");
                    break;
                    case 7:
                    Console.WriteLine("bazar");
                    break;
                default:
                    Console.WriteLine("daxil etdiyiniz gun yoxdur");
                    break ;
            }
        }
    }
}
