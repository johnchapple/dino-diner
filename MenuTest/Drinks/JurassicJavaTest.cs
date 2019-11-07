using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(0.59, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultProperties()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
            Assert.False(jj.Decaf);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal(0.99, jj.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, jj.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal(1.49, jj.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, jj.Size);
        }

        [Fact]
        public void ShouldBeAbleToLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void ShouldHaveIceSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Contains("Add Ice", jj.Special);
        }

        [Fact]
        public void ShouldHaveRoomForCreamSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Contains("Leave Room for Cream", jj.Special);
        }

        [Fact]
        public void ShouldHaveAllSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            jj.AddIce();
            Assert.Contains("Leave Room for Cream", jj.Special);
            Assert.Contains("Add Ice", jj.Special);
        }
    }
}
