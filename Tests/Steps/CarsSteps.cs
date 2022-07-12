using Domain.Aggregates;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Web.Controllers;

namespace Tests.Steps;

[Binding]
public class StartupSteps
{
    private IReadOnlyCollection<Car> carsInTheGarage;
    private StartupController startupController = new StartupController(new Logger<Car>(LoggerFactory.Create((c) => c.AddConsole() )));

    [Given(@"i have (.*) cars in the garage")]
    public void GivenIHaveCarsInTheGarage(int p0)
    {
    }

    [When(@"i want to list the cars i have")]
    public async Task WhenIWantToListTheCarsIHave()
    {
        carsInTheGarage = await startupController.ListCars();
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int nbCarsRetrieved)
    {
        carsInTheGarage.Should().HaveCount(2);
    }
}