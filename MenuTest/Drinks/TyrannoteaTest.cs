using System;
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        /// <summary>
        /// Expected values/test vectors 
        /// </summary>
        double[] prices = { .99, 1.49, 1.99 };
        uint[] calories = { 8, 16, 32 };

        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Tea",
            "Lemon",
            "Cane Sugar"
        };

        /// <summary>
        /// Verify the correct default values
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(prices[0], tea.Price);
            Assert.Equal(calories[0], tea.Calories);
            Assert.True(tea.Ice);
            Assert.False(tea.Lemon);
            Assert.False(tea.Sweet);
        }
        /// <summary>
        /// Verify all prices and calores are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            for (uint i = 0; i < 3; i++)
            {
                tea.Size = (Size)i;
                Assert.Equal(prices[i], tea.Price, 2);
                Assert.Equal(calories[i], tea.Calories);
            }
        }
        /// <summary>
        /// Verify hodl ice removes ice
        /// </summary>
        [Fact]
        public void HoldIceShouldSetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        /// <summary>
        /// Verify lemon can be added
        /// </summary>
        [Fact]
        public void AddLemonShouldSetTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        /// <summary>
        /// Verify sweet results in correct calories
        /// </summary>
        [Fact]
        public void SweetResultsInCorrectCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            for (uint i = 0; i < 3; i++)
            {
                tea.Size = (Size)i;
                Assert.Equal(calories[i] * 2, tea.Calories);
            }
        }
        /// <summary>
        /// Verify resetting sweet has correct calories
        /// </summary>
        [Fact]
        public void ResetSweetResultsInCorrectCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            for (uint i = 0; i < 3; i++)
            {
                tea.Size = (Size)i;
                Assert.Equal(calories[i], tea.Calories);
            }
        }
        /// <summary>
        /// Verify all ingredients are correct
        /// </summary>
        public void HasCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            for( int i = 0; i < 2; i++ )
                Assert.Equal(expectedIngredients[i], tea.Ingredients[i]);
            tea.AddLemon();
            for( int i = 0; i < 3; i++ )
                Assert.Equal(expectedIngredients[i], tea.Ingredients[i]);
            tea.Sweet = true;
            for (int i = 0; i < 4; i++)
                Assert.Equal(expectedIngredients[i], tea.Ingredients[i]);
        }
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionIsCorrect(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }
        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]

        public void SpecialIsCorrect(bool HoldIce, bool AddLemon)
        {
            List<String> test_lst = new List<string>();
            Tyrannotea tea = new Tyrannotea();
            if (HoldIce)
            {
                tea.HoldIce();
                test_lst.Add("Hold Ice");
            }
            if (AddLemon)
            {
                tea.AddLemon();
                test_lst.Add("Add Lemon");
            }

            Assert.Equal(test_lst.ToArray(), tea.Special);
        }
        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void SizeChangeShouldNotifyChange(string expected)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, expected, () =>
            {
                tea.Size = Size.Medium;
            });
        }
        [Theory]
        [InlineData("Ingredients")]
        [InlineData("Name")]
        [InlineData("Calories")]
        public void SweetShouldNotifyChange(string expected)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, expected, () =>
            {
                tea.Sweet = true;
            });
        }
        [Theory]
        [InlineData("Special")]
        public void AddLemonShouldNotifyChange(string expected)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, expected, () =>
            {
                tea.AddLemon();
            });
        }
        [Theory]
        [InlineData("Special")]
        public void HoldIceShouldNotifyChange(string expected)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, expected, () =>
            {
                tea.HoldIce();
            });
        }

    }
}
