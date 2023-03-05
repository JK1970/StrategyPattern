namespace StrategyPattern.Models
{
    public class BicycleRouteCalculationBehaviour : RouteCalculationBehaviour
    {
        public override void CalculateRoute()
        {
            Console.WriteLine("Route for bicycle is calculated.");
        }
    }
}