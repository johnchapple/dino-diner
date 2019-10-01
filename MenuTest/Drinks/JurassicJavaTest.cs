using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal(0.59, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultProperties()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.RoomForCream);
            Assert.False(jj.Decaf);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal(0.99, jj.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, jj.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal(1.49, jj.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, jj.Size);
        }

        [Fact]
        public void ShouldBeAbleToLeaveRoomForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }
    }
}
