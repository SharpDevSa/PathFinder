using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFiender;
using PathFiender.Types;

namespace UnitTestFiender
{
    [TestClass]
    public class TestBreadthFirst
    {
        [TestMethod]
        public void TestBreadthFirstPoint1()
        {
            Node endPosition = new Node(2, 1);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(1, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint2()
        {
            Node endPosition = new Node(2, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(3, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint3()
        {
            Node endPosition = new Node(4, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(5, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint4()
        {
            Node endPosition = new Node(4, 4);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(6, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint5()
        {
            Node endPosition = new Node(7, 2);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(11, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint6()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint7()
        {
            Node endPosition = new Node(5, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }
        [TestMethod]
        public void TestBreadthFirstPoint8()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint9()
        {
            Node endPosition = new Node(1, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }

        [TestMethod]
        public void TestBreadthFirstPoint10()
        {
            Node endPosition = new Node(1, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.BreadhFirsSearch);
            Assert.AreEqual(4, result[PathMapBuilder.Searcher.BreadhFirsSearch].Count);
        }
    }
}
