using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal(0.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Equal<int>(2, tt.Ingredients.Count);
            tt.AddLemon();
            Assert.Contains<string>("Lemon", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
            tt.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tt.Ingredients);
            Assert.Equal<int>(4, tt.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Sweet);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal(1.49, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal(1.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.True(tt.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesSweetenSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Size = Size.Small;
            Assert.Equal<uint>(16, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesSweetenMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
            Assert.Equal<uint>(32, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesSweetenLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
            Assert.Equal<uint>(64, tt.Calories);
        }
    }
}
