namespace Preparitve_focus_gradient_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int walkupnum;
            //user walkup instrument
            Console.WriteLine("which walkup instrument did you use?");
            walkupnum = Convert.ToInt32(Console.ReadLine());
            switch (walkupnum)
            {
                case 1:
                case 2: highnumberfour(); break;
                case 3:
                case 4:
                case 5:
                case 6: highnumberfour(); break;
            }
            static void highnumberfour()
            {
                double time;
                bool inbound = true;
                double Gradient_Center;
                double M = 27.137;
                double B = -31.741;
                Console.Write("Retention time (min)");
                do
                {
                    time = Convert.ToInt32(Console.ReadLine());
                    if (time >= 0 || time > 4.7)
                    {
                        inbound = false;
                    }
                    else
                    {
                        inbound = true;
                    }
                }
                while (inbound == false);
                Gradient_Center = M * (time) + B;
            }
        }
    }
}
