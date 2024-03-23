namespace BikeTDD.Code;

public class CalculateRentalPriceService
{
    public decimal CalculateBikePrice(int hours)
    {
        decimal firstHour = 5;
        decimal hourlyRate = 2;
        decimal lateFee = 25;
        
        if (hours is > 1 and < 6)
        {
            return (firstHour + (hourlyRate * (hours - 1)));
        }
        else if (hours >= 6)
        {
            return (firstHour + (hourlyRate * (hours - 1)) + lateFee);
        }
        else
        {
            return firstHour; 
        }
    }
}

//Services/Classes:
//1. Customers (get/store ids, get/store personal details)
//2. Bikes (bike id, available?, location)
//3. Pick-up/Drop-off Locations (local ids, count of bikes at each local)
//customers can save fav locals
//4. Rental (Costs £5 for 1st hour, £2 per hour after.
//Max time of 5 hours or £25 charge. No return is criminal charge)
//5.Notifications - send itemized bill after hire
//Read QR Code (store images?)