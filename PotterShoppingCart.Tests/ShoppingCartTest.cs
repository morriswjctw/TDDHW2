using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// ShoppingCartTest 的摘要描述
    /// </summary>
    [TestClass]
    public class ShoppingCartTest
    {
        public ShoppingCartTest()
        {
            //
            // TODO:  在此加入建構函式的程式碼
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合
        ///的相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 其他測試屬性
        //
        // 您可以使用下列其他屬性撰寫您的測試: 
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void 只買第1集1本_價錢合計100元()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 } };

            int expected = 100;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第1集1本第2集1本_價格應為190()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { 
                new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 },
                new Potter { BookClass = 2, BookName = "哈利波特2", Amount = 1, Price = 100 } 
            };

            int expected = 190;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第1集1本第2集1本第3集1本_價格應為270()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { 
                new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 },
                new Potter { BookClass = 2, BookName = "哈利波特2", Amount = 1, Price = 100 },
                new Potter { BookClass = 3, BookName = "哈利波特3", Amount = 1, Price = 100 } 
            };

            int expected = 270;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第1集1本第2集1本第3集1本第4集1本_價格應為320()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { 
                new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 },
                new Potter { BookClass = 2, BookName = "哈利波特2", Amount = 1, Price = 100 },
                new Potter { BookClass = 3, BookName = "哈利波特3", Amount = 1, Price = 100 },
                new Potter { BookClass = 4, BookName = "哈利波特4", Amount = 1, Price = 100 } 
            };

            int expected = 320;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第1集1本第2集1本第3集1本第4集1本第5集1本_價格應為375()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { 
                new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 },
                new Potter { BookClass = 2, BookName = "哈利波特2", Amount = 1, Price = 100 },
                new Potter { BookClass = 3, BookName = "哈利波特3", Amount = 1, Price = 100 },
                new Potter { BookClass = 4, BookName = "哈利波特4", Amount = 1, Price = 100 },
                new Potter { BookClass = 5, BookName = "哈利波特5", Amount = 1, Price = 100 }
            };

            int expected = 375;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第1集1本第2集1本第3集2本_價格應為370()
        {
            //Arrange
            var target = new Bill();
            var Product = new List<Potter> { 
                new Potter { BookClass = 1, BookName = "哈利波特1", Amount = 1, Price = 100 },
                new Potter { BookClass = 2, BookName = "哈利波特2", Amount = 1, Price = 100 },
                new Potter { BookClass = 3, BookName = "哈利波特3", Amount = 2, Price = 100 }
            };

            int expected = 370;
            //Act
            int actual = target.Checkout(Product);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
