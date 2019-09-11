using DevopsWorld.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevopsWorld.Tests
{
    public class HomeUnitTest
    {
        [Fact]
        public void Test_Index()
        {
        //Given
        var sut = new HomeController();
        //When
        var view = sut.Index();
        //Then
        Assert.NotNull(view);
        Assert.IsType<ViewResult>(view);
        }

        [Fact]
        public void Test_Privacy()
        {
        var sut = new HomeController();
        //When
        var view = sut.Privacy();
        //Then
        Assert.NotNull(view);
        Assert.IsType<ViewResult>(view);
        }
    }
}