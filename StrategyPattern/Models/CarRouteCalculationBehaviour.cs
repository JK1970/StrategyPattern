namespace StrategyPattern.Models
{
    public class CarRouteCalculationBehaviour : RouteCalculationBehaviour
    {
        public override void CalculateRoute()
        {
            Console.WriteLine("Route for car is calculated.");
        }
    }
}