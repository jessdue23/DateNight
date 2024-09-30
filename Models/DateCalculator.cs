namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost { get; set; }
    public string DinnerCost { get; set; }
    public string MovieCost { get; set; }

    public string GetTotalCost()
    {

        decimal decCoffee, decDinner, decMovie;
        if (!Decimal.TryParse(CoffeeCost,out decCoffee))
        {
            if (!String.IsNullOrEmpty(CoffeeCost))
            {
                throw new Exception("Invalid Coffee Cost");
            }
        }
        
        
        if (!Decimal.TryParse(DinnerCost,out decDinner))
        {
            if (!String.IsNullOrEmpty(DinnerCost))
            {
                throw new Exception("Invalid Dinner Cost");
            }
        }
        
        
        if (!Decimal.TryParse(MovieCost,out decMovie))
        {
            if (!String.IsNullOrEmpty(MovieCost))
            {
                throw new Exception("Invalid Movie Cost");
            }
        }
        
        
        return (decCoffee+decMovie+decDinner).ToString("c");
    }
}