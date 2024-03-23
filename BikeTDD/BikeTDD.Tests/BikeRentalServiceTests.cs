using BikeTDD.Code;
    
namespace BikeTDD.Tests;

public class BikeRentalServiceTests
{
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 7)]
    [InlineData(3, 9)]
    [InlineData(4, 11)]
    [InlineData(5, 13)]
    [InlineData(6, 40)]
    [InlineData(10, 48)]
    public void CalculateBikeRentalPrice_InputHours_ReturnTotal(int hours, decimal totalCost)
    {
        //arrange
        var priceCalculator = new CalculateRentalPriceService();
        //act
        decimal result = priceCalculator.CalculateBikePrice(hours);
            
        //assert
        Assert.Equal(totalCost, result);
        
    }
}

// X Rental (Costs £5 for 1st hour, £2 per hour after.
//Max time of 5 hours or £25 charge (on top of hourly rate?). No return is criminal charge)

