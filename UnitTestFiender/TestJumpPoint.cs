using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFiender;
using PathFiender.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFiender
{
    [TestClass]
    public class TestJumpPoint
    {
        //vert horiz
        [TestMethod]
        public void TestJumpPoint1() {
            Node endPosition = new Node(2, 1);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(1, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint2()
        {
            Node endPosition = new Node(2, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(3, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint3()
        {
            Node endPosition = new Node(4, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(5, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint4()
        {
            Node endPosition = new Node(4, 4);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(6, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint5()
        {
            Node endPosition = new Node(7, 2);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(11, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint6()
        {
            Node endPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(10, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint7()
        {
            Node endPosition = new Node(5, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }
        [TestMethod]
        public void TestJumpPoint8()
        {
            Node endPosition = new Node(8, 8);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint9()
        {
            Node endPosition = new Node(1, 7);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(14, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }

        [TestMethod]
        public void TestJumpPoint10()
        {
            Node endPosition = new Node(1, 3);
            PathMapBuilder builder = new PathMapBuilder(endPosition, false);
            var result = builder.Execute(PathMapBuilder.Searcher.JumpPointSearch);
            Assert.AreEqual(4, result[PathMapBuilder.Searcher.JumpPointSearch].Count);
        }



    }
}
