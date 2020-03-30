using NUnit.Framework;
using P = NET.S._2020.Vakula._6;
using System;

namespace Polynomial.Tests
{
    public class JaggedSortTests
    {
        int[][] arr = new int[][] {
            new int[] { 3, 2, 0 },
            new int[] { 2, 2, 2 },
            new int[] { 1, 2, -1 } };


        [Test]
        public void SortBySumAscCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 1, 2, -1 },
                new int[] { 3, 2, 0 },
                new int[] { 2, 2, 2 }};

            P.JaggedSort.SortBySumAsc(arr);
            Assert.AreEqual(arr,result);
        }

        [Test]
        public void SortBySumDescCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 2, 2, 2 },
                new int[] { 3, 2, 0 },
                new int[] { 1, 2, -1 } };

            P.JaggedSort.SortBySumDesc(arr);
            Assert.AreEqual(arr, result);
        }

        [Test]
        public void SortByMinElemAscCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 1, 2, -1 },
                new int[] { 3, 2, 0 },
                new int[] { 2, 2, 2 }};

            P.JaggedSort.SortByMinElemAsc(arr);
            Assert.AreEqual(arr, result);
        }

        [Test]
        public void SortByMinElemDescCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 2, 2, 2 },
                new int[] { 3, 2, 0 },
                new int[] { 1, 2, -1 }};

            P.JaggedSort.SortByMinElemDesc(arr);
            Assert.AreEqual(arr, result);
        }

        [Test]
        public void SortByMaxElemAscCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 2, 2, 2 },
                new int[] { 1, 2, -1 },
                new int[] { 3, 2, 0 }};

            P.JaggedSort.SortByMaxElemAsc(arr);
            Assert.AreEqual(arr, result);
        }

        [Test]
        public void SortByMaxElemDescCorrectArrayCorrectAns()
        {
            int[][] result = new int[][] {
                new int[] { 3, 2, 0 },
                new int[] { 2, 2, 2 },
                new int[] { 1, 2, -1 }};

            P.JaggedSort.SortByMaxElemDesc(arr);
            Assert.AreEqual(arr, result);
        }
        /// <summary>
        /// Testing exceptions
        /// </summary>
       
        int[][] test1 = null;

        int[][] test2 = new int[][] {
                new int[]{ 3, 2, 0},
                null};

        [Test]
        public void SortByMaxElemAscWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemAsc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemAsc(test2));
        }

        [Test]
        public void SortByMaxElemDescWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test2));
        }

        [Test]
        public void SortByMinElemAscWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMinElemAsc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMinElemAsc(test2));
        }

        [Test]
        public void SortByMinElemDescWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test2));
        }

        [Test]

        public void SortBySumAscWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortBySumAsc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortBySumAsc(test2));
        }

        [Test]
        public void SortBySumDescWrongDataNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test1));
            Assert.Throws<NullReferenceException>(() => P.JaggedSort.SortByMaxElemDesc(test2));
        }

    }
}