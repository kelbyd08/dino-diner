using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        class MockEntree : Entree
        {
            public override string[] Special => throw new NotImplementedException();

            public MockEntree( double price)
            {
                this.price = price;
            }
        }
        class MockDrink : Drink
        {
            public override string[] Special => throw new NotImplementedException();
            private double price;

            public MockDrink(double price)
            {
                this.price = price;
            }
            public override double Price
            {
                get { return price; }
            }
        }
        class MockSide : Side
        {
            public override string[] Special => throw new NotImplementedException();
            private double price;
            public MockSide(double price)
            {
                this.price = price;

            }
            public override double Price{
                get { return price; }
                }
        }
        [Theory]
        [InlineData(.08, 3, 2, 1, 6.48)]
        [InlineData(.2, 3, 52, 45, 120)]
        [InlineData(1, 1, 2, 7, 20)]
        [InlineData(.08, 3, 2, -901, 0)]
        public void OrderCostIsCalculatedCorrectly( double tax, 
                                                    double entreePrice, 
                                                    double drinkPrice, 
                                                    double sidePrice, 
                                                    double exCost)
        {
            MockEntree entree = new MockEntree(entreePrice);
            MockDrink drink = new MockDrink(drinkPrice);
            MockSide side = new MockSide(sidePrice);
            Order odr = new Order(tax);

            odr.Items.Add(entree);
            odr.Items.Add(drink);
            odr.Items.Add(side);
            Assert.Equal(exCost, odr.TotalCost);
        }
    }
}
