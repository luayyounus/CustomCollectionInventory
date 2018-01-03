using System;
using EcommerceStore.Classes;
using Xunit;

namespace XUnitTestEcommerceStore
{
    public class UnitTest1
    {
        [Fact]
        public void Return_Equal_Inventory_Count_When_Adding()
        {
            // Arrange
            Product product = new Product("Computer", ProductType.Home);
            Inventory<Product> inventory = new Inventory<Product>();

            // Act
            inventory.Add(product);

            // Assert
            Assert.Equal(1, inventory.Count);
        }

        [Fact]
        public void Return_Inventory_Half_Size_When_Removing()
        {
            // Arrange
            Product product = new Product("Computer", ProductType.Home);
            Inventory<Product> inventory = new Inventory<Product>();

            // Act
            inventory.Add(product);
            inventory.Remove(product); // Resizing to half after removing

            // Assert
            Assert.Equal(5, inventory.Items.Length);
        }
    }
}
