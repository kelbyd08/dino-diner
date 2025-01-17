﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class WaterTest
    {
        /// <summary>
        /// Expected values/test vectors
        /// </summary>
        double[] prices = { .1, .1, .1 };
        uint[] calories = { 0, 0, 0 };

        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Lemon"
        };
        /// <summary>
        /// Verify the default properties are correct
        /// </summary>
        [Fact]
        public void CorrectDefaultProperties()
        {
            Water wtr = new Water();
            Assert.Equal(prices[0], wtr.Price);
            Assert.Equal(calories[0], wtr.Calories);
            Assert.Equal(Size.Small, wtr.Size);
            Assert.True(wtr.Ice);
        }
        /// <summary>
        /// Verify all prices and calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            Water wtr = new Water();
            for (uint i = 0; i < 3; i++)
            {
                wtr.Size = (Size)i;
                Assert.Equal(prices[i], wtr.Price, 2);
                Assert.Equal(calories[i], wtr.Calories);
            }
        }
        /// <summary>
        /// Verify the ice can be removed
        /// </summary>
        [Fact]
        public void HoldIceShouldSetFalse()
        {
            Water wtr = new Water();
            Assert.True(wtr.Ice);
            wtr.HoldIce();
            Assert.False(wtr.Ice);
        }
        /// <summary>
        /// Verify lemon can be added
        /// </summary>
        [Fact]
        public void AddLemonShouldSetTrue()
        {
            Water wtr = new Water();
            Assert.False(wtr.Lemon);
            wtr.AddLemon();
            Assert.True(wtr.Lemon);
        }
        /// <summary>
        /// Verify the ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water wtr = new Water();
            Assert.Equal(expectedIngredients[0], wtr.Ingredients[0]);
            wtr.AddLemon();
            Assert.Equal(expectedIngredients, wtr.Ingredients);

        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionIsCorrect(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }
                [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]

        public void SpecialIsCorrect(bool HoldIce, bool AddLemon)
        {
            List<String> test_lst = new List<string>();
            Water water = new Water();
            if (HoldIce)
            {
                water.HoldIce();
                test_lst.Add("Hold Ice");
            }
            if (AddLemon)
            {
                water.AddLemon();
                test_lst.Add("Add Lemon");
            }

            Assert.Equal(test_lst.ToArray(), water.Special);
        }
        [Theory]
        [InlineData("Special")]
        public void HoldIceShouldNotifyChange(string expected)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, expected, () =>
            {
                water.HoldIce();
            });
        }
        [Theory]
        [InlineData("Special")]
        public void AddLemonShouldNotifyChange(string expected)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, expected, () =>
            {
                water.AddLemon();
            });
        }
    }
}
