using System;
using System.Collections.Generic;
using PromotionEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ScenarioA_Test()
        {
            //Initialize
             List<Product> product =new List<Product>();
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="C"});
            
            //Action
            ProductService productService=new ProductService();
            int totalPrice= productService.GetTotalPrice(products);
            
            //Assert
            Assert.AreEqual<int>(100,totalPrice);
        }

        [TestMethod]
        public void ScenarioB_Test()
        {
            //Initialize
            List<Product> product =new List<Product>();
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="C"});
            
             //Action
            ProductService productService=new ProductService();
            int totalPrice= productService.GetTotalPrice(products);
            
            //Assert
            Assert.AreEqual<int>(370,totalPrice);
        }

        [TestMethod]
        public void ScenarioC_Test()
        {
            //Initialize
            List<Product> product =new List<Product>();
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="C"});
            ProductService.Add(new Product(){Id="D"});
            
            //Action
            ProductService productService=new ProductService();
            int totalPrice= productService.GetTotalPrice(products);
            
            //Assert
            Assert.AreEqual<int>(280,totalPrice);
        }
        [TestMethod]
        public void NoProductsScenario_Test()
        {
            //Initialize
            List<Product> product =new List<Product>();
            
            //Action
            ProductService productService=new ProductService();
            int totalPrice= productService.GetTotalPrice(products);
            
            //Assert
            Assert.AreEqual<int>(280,totalPrice);
        }
    }
}
