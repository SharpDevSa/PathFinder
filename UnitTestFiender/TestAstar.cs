using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFiender;
using PathFiender.Types;

namespace UnitTestFiender
{
    [TestClass]
    public class TestAstar
    {
        [TestMethod]
        public void TestAstarPoint1()
        {
            Node endPosition = new Node(2, 1);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(1, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint2()
        {
            Node endPosition = new Node(2, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(3, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint3()
        {
            Node endPosition = new Node(4, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(5, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint4()
        {
            Node endPosition = new Node(4, 4);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(6, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint5()
        {
            Node endPosition = new Node(7, 2);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(11, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint6()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint7()
        {
            Node endPosition = new Node(5, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.AStar].Count);
        }
        [TestMethod]
        public void TestAstarPoint8()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint9()
        {
            Node endPosition = new Node(1, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.AStar].Count);
        }

        [TestMethod]
        public void TestAstarPoint10()
        {
            Node endPosition = new Node(1, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.AStar);
            Assert.AreEqual(4, result[PathMapBuilder.Searcher.AStar].Count);
        }
    }
}
