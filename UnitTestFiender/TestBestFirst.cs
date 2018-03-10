using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFiender;
using PathFiender.Types;

namespace UnitTestFiender
{
    [TestClass]
     public class TestBestFirst
    {
        [TestMethod]
        public void TestBestFirstPoint1()
        {
            Node endPosition = new Node(2, 1);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(1, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint2()
        {
            Node endPosition = new Node(2, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(3, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint3()
        {
            Node endPosition = new Node(4, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(5, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint4()
        {
            Node endPosition = new Node(4, 4);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(6, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint5()
        {
            Node endPosition = new Node(7, 2);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(11, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint6()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint7()
        {
            Node endPosition = new Node(5, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }
        [TestMethod]
        public void TestBestFirstPoint8()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint9()
        {
            Node endPosition = new Node(1, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }

        [TestMethod]
        public void TestBestFirstPoint10()
        {
            Node endPosition = new Node(1, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BestFirstSearch);
            Assert.AreEqual(4, result[PathMapBuilder.Searcher.BestFirstSearch].Count);
        }
    }
}
