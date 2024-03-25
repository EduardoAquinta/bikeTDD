using BikeTDD.Code;
    
namespace BikeTDD.Tests;

public class Each_Bike_Has_Valid_ID_And_Hired_Status_Attached
{
    [Fact]
    public void Bike_Has_Valid_ID()
    {
        //assign
        var newBikeId = new BikeDetails();
        //act
        int ID = newBikeId.BikeID(123456); ;
        int IDLength = ID.ToString().Length;
        //assert
        Assert.Equal(123456, ID);
        Assert.Equal(6, IDLength );
    }

    [Fact]
    public void Bike_Has_InValid_ID()
    {
        var newBikeId = new BikeDetails();
        int ID = newBikeId.BikeID(12345);
        int IDLength = ID.ToString().Length;
        Assert.NotEqual(123456, ID);
        Assert.NotEqual(6, IDLength);
    }

    [Fact]
    public void Bike_Is_Hired()
    {
        var bikeHired = new BikeDetails();
        bool bikeIsHired = bikeHired.BikeIsHired(true);
        Assert.True(bikeIsHired);
    }
}