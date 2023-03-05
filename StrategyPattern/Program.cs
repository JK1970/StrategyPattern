using StrategyPattern.Models;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Navigator navigator = new()
            {
                RouteCalculationBehaviour = new CarRouteCalculationBehaviour()
            };

            navigator.CalculateRoute();

            navigator.RouteCalculationBehaviour = new MotorcycleRouteCalculationBehaviour();

            navigator.CalculateRoute();
        }
    }

}
