namespace StrategyPattern.Models
{
    public class Navigator
    {
        public RouteCalculationBehaviour RouteCalculationBehaviour { get; set; } = default!;

        public void CalculateRoute()
        {
            RouteCalculationBehaviour.CalculateRoute();
        }
    }
}