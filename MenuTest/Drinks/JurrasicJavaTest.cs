using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        /// <summary>
        /// Expected lists
        /// </summary>
        double[] prices = { .59, .99, 1.49 };
        uint[] calories = { 2, 4, 8 };
        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Coffee",
        };

        /// <summary>
        /// Verify the object has the correct default properties
        /// </summary>
        [Fact]
        public void CorrectDefaultProperties()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(prices[0], jj.Price);
            Assert.Equal(calories[0], jj.Calories);
            Assert.Equal(Size.Small, jj.Size);
            Assert.False(jj.SpaceForCream);
            Assert.False(jj.Ice);
            Assert.False(jj.Decaf);
        }

        /// <summary>
        /// Verify the price and calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            JurassicJava jj = new JurassicJava();
            for (uint i = 0; i < 3; i++)
            {
                jj.Size = (Size)i;
                Assert.Equal(prices[i], jj.Price, 2);
                Assert.Equal(calories[i], jj.Calories);
            }
        }
        /// <summary>
        /// Verify adding ice works correctly 
        /// </summary>
        [Fact]
        public void AddIceShouldSetTrue()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
            jj.AddIce();
            Assert.True(jj.Ice);
        }
        /// <summary>
        /// Verify space can be left for cream
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamShouldSetTrue()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.SpaceForCream);
            jj.LeaveRoomForCream();
            Assert.True(jj.SpaceForCream);
        }
        /// <summary>
        /// Verify the ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(expectedIngredients, jj.Ingredients);
        }
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurassicJavaDescriptionIsCorrect(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }
        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]

        public void SpecialIsCorrect(bool AddIce, bool LeaveSpace)
        {
            List<String> test_lst = new List<string>();
            JurassicJava java = new JurassicJava();
            if (AddIce)
            {
                java.AddIce();
                test_lst.Add("Add Ice");
            }
            if (LeaveSpace)
            {
                java.LeaveRoomForCream();
                test_lst.Add("Leave Room For Cream");
            }

            Assert.Equal(test_lst.ToArray(), java.Special);
        }
        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void SizeChangeShouldNotifyChange(string expected)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, expected, () =>
            {
                java.Size = Size.Medium;
            });
        }
        [Theory]
        [InlineData("Special")]
        public void AddIceShouldNotifyChange(string expected)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, expected, () =>
            {
                java.AddIce();
            });
        }
        [Theory]
        [InlineData("Special")]
        public void RoomForCreamShouldNotifyChange(string expected)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, expected, () =>
            {
                java.LeaveRoomForCream();
            });
        }
    }
}
