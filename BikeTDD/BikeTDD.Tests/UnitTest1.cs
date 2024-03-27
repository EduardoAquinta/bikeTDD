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
        int id = newBikeId.BikeId(123456); ;
        int idLength = id.ToString().Length;
        //assert
        Assert.Equal(123456, id);
        Assert.Equal(6, idLength );
    }

    [Fact]
    public void Bike_Has_InValid_ID()
    {
        var newBikeId = new BikeDetails();
        int id = newBikeId.BikeId(12345);
        int idLength = id.ToString().Length;
        Assert.NotEqual(123456, id);
        Assert.NotEqual(6, idLength);
    }

    [Fact]
    public void Bike_Is_Hired()
    {
        var bikeHired = new BikeDetails();
        bool bikeIsHired = bikeHired.BikeIsHired(true);
        Assert.True(bikeIsHired);
    }

    [Fact]
    public void Bike_Is_Not_Hired()
    {
        var bikeNotHired = new BikeDetails();
        bool bikeIsNotHired = bikeNotHired.BikeIsHired(false);
        Assert.False(bikeIsNotHired);
    }
}