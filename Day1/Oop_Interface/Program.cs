namespace Oop_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Implicit implementation of interface IDrink
            //Drink drink = new Drink();
            //drink.GetDrink();
            //#endregion


            #region Implict implementation
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    IDrink coldDrink = new ColdDrink();
                    coldDrink.GetDrink();
                    break;
                case 2:
                    IDrink hotDrink = new HotDrink();
                    hotDrink.GetDrink();
                    break;
                default:
                    Console.WriteLine("Invalid choice");

                    break;
            }
        }
    #endregion





    //#region Implicit implementation of interface IDrink
    //public interface IDrink
    //{ 
    //    void GetDrink();
    //}

    //public class Drink : IDrink
    //{
    //    public void GetDrink()
    //    {
    //        Console.WriteLine("Enjoy your Drink!!");
    //    }
    //}
    //#endregion

    #region implicit implementation
    public interface IDrink
    {
        void GetDrink();
    }
    public class ColdDrink : IDrink
    {

        public void GetDrink()

        {
            Console.WriteLine("Enjoy your Cold Drink!!");
        }
    }
    public class HotDrink : IDrink
    {
        public void GetDrink()
        {
            Console.WriteLine("Enjoy your Hot Drink!!");
        }
    }
    #endregion
}
}

