namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SoccerBall KickOff = new SoccerBall("White", "Sphere", "Addidas");


            Console.WriteLine(KickOff.GetColour());
            Console.WriteLine(KickOff.GetShape());
            Console.WriteLine(KickOff.GetBrand());
        }
    }
}
