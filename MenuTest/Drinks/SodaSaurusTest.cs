using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal(1.50, ss.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<uint>(112, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Natural Flavors", ss.Ingredients);
            Assert.Contains<string>("Cane Sugar", ss.Ingredients);
            Assert.Equal<int>(3, ss.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal(2.00, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(156, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ss.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal(2.50, ss.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<uint>(208, ss.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ss.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal("Sodasaurus", jj.Description);
        }
    }
}
