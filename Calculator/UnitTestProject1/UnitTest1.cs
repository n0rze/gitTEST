using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            BubbleSort srt = new BubbleSort();
            Random rand = new Random();
            int[] arr = new int[1000];

            for (int i = 0; i < 1000; i++)
                arr[i] = rand.Next(0, 100);

            Assert.AreEqual(srt.Sort(arr).Length, arr.Length); 
        }

        [TestMethod]
        public void Test2()
        {
            BubbleSort srt = new BubbleSort();

            Random rand = new Random();

            int[] arr = new int[1000];

            Vybor vybor = new Vybor();

            for (int i = 0; i < 1000; i++)
                arr[i] = rand.Next(0, 100);

            //Assert.AreEqual(srt.Sort(arr), vybor.Selection(arr));
            Assert.ReferenceEquals(srt.Sort(arr), vybor.Selection(arr));

        }

    }
}
