namespace StrategyPattern.Models
{
    public class MotorcycleRouteCalculationBehaviour : RouteCalculationBehaviour
    {
        public override void CalculateRoute()
        {
            Console.WriteLine("Route for motorcycle is calculated.");
        }
    }
}