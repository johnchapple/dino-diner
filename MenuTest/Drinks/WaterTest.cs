using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal(0.1, w.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultProperties()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            w.AddLemon();
            Assert.Contains<string>("Lemon", w.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal(0.1, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, w.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal(0.1, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, w.Size);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
    }
}
