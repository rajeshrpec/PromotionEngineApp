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
             List<Product> product =new List<Product>();
            ProductService.Add(new Product(){Id="A"});
            ProductService.Add(new Product(){Id="B"});
            ProductService.Add(new Product(){Id="C"});

            ProductService productService=new ProductService();
            int totalPrice= productService.GetTotalPrice(products);

            Assert.AreEqual<int>(100,totalPrice);
        }

        [TestMethod]
        public void ScenarioB_Test()
        {
            
        }

        [TestMethod]
        public void ScenarioC_Test()
        {
            
        }
    }
}
