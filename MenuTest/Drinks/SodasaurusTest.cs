using System;
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        /// <summary>
        /// Expected values/test vectors
        /// </summary>
        double[] prices = { 1.5, 2, 2.5 };
        uint[] calories = { 112, 156, 208 };
        enum expectedFlavors
        {
            Cola,
            Orange,
            Vanilla,
            Chocolate,
            RootBeer,
            Cherry,
            Lime
        }

        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Natural Flavors",
            "Cane Sugar"
        };

        /// <summary>
        /// Verify the correct default price and calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            for (uint i = 0; i < 3; i++)
            {
                soda.Size = (Size)i;
                Assert.Equal(prices[ i ], soda.Price, 2);
                Assert.Equal(calories[i], soda.Calories);
            }
        }
        /// <summary>
        /// Verify the correct flavors 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectFlavors()
        {
            Sodasaurus soda = new Sodasaurus();
            for ( uint i = 0; i < Enum.GetNames( typeof( expectedFlavors ) ).Length; i++)
            {
                soda.flavor = (SodasaurusFlavor)i;
                Assert.Equal( Enum.GetNames( typeof( expectedFlavors ) )[ i ]
                            , soda.flavor.ToString () );
            }
        }
        /// <summary>
        /// Verify ice is held correctly
        /// </summary>
        [Fact]
        public void HoldIceShouldSetFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        /// <summary>
        /// Verify the correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(expectedIngredients, soda.Ingredients);
        }
        /// <summary>
        /// Verify the default values are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(prices[0], soda.Price);
            Assert.Equal(calories[0], soda.Calories);
            Assert.Equal(Size.Small, soda.Size);
        }
        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusDescriptionIsCorrect(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }
        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void SpecialIsCorrect(bool HoldIce)
        {
            List<String> test_lst = new List<string>();
            Sodasaurus soda = new Sodasaurus();
            if (HoldIce)
            {
                soda.HoldIce();
                test_lst.Add("Hold Ice");
            }

            Assert.Equal(test_lst.ToArray(), soda.Special);
        }
        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void SizeChangeShouldNotifyChange(string expected)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, expected, () =>
            {
                soda.Size = Size.Medium;
            });
        }
        [Theory]
        [InlineData("Special")]
        public void HoldIceShouldNotifyChange(string expected)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, expected, () =>
            {
                soda.HoldIce();
            });
        }
    }
}
