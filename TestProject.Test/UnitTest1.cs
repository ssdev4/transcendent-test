using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TestProject.Controllers;
using TestProject.Models;
using TestProject.Repository.Abstraction;
using Xunit;

public class NumberControllerTests
{
    [Fact]
    public async Task Index_ReturnsAViewResult_WithAllNumbers()
    {
        var mockNumberService = new Mock<INumberService>();
        var controller = new NumberController(mockNumberService.Object);

        var result = await controller.Index();

        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task Calculate_WhenModelStateIsValid_RedirectsToIndex()
    {
        var mockNumberService = new Mock<INumberService>();
        var controller = new NumberController(mockNumberService.Object);
        var model = new NumberEntry();

        controller.ModelState.Clear();
        var result = await controller.Calculate(model) as RedirectToActionResult;

        Assert.NotNull(result);
        Assert.Equal("Index", result.ActionName);
    }

    [Fact]
    public async Task Calculate_WhenModelStateIsNotValid_ReturnsViewWithModel()
    {
        var mockNumberService = new Mock<INumberService>();
        var controller = new NumberController(mockNumberService.Object);
        var model = new NumberEntry();
        controller.ModelState.AddModelError("PropertyName", "Error Message");

        var result = await controller.Calculate(model) as ViewResult;

        Assert.NotNull(result);
        Assert.Equal("Index", result.ViewName);
        Assert.Same(model, result.Model);
    }
}
