using Bunit;
using MyFirstMudBlazorProject.Pages;
using System.Diagnostics.Metrics;

namespace MyFirstBlazorTestProject
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            var cut = RenderComponent<Counter>();
            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p class=\"mud-typography mud-typography-body1 mb-4\">Current count: 1</p>");
        }
    }
}