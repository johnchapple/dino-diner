using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void ShouldHaveAllSpecial()
        {
            PterodactylWings pw = new PterodactylWings();
            pw.HoldOnion();
            pw.HoldPeppers();
            pw.HoldBun();
            Assert.Contains("Hold Onions", pw.Special);
            Assert.Contains("Hold Peppers", pw.Special);
            Assert.Contains("Hold Bun", pw.Special);
        }

        [Theory]
        [InlineData("Special")]
        public void AddingNuggetsShouldNotifyOfPropertyChange(string propertyName)
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.PropertyChanged(pw, propertyName, () =>
            {
                pw.HoldOnion();
            });
        }
    }
}
