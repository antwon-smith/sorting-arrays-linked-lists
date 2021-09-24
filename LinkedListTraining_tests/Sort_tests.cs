﻿using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class Sort_tests
    {
        [TestMethod]
        public void Test_Can_Fail()
        {
            //Assert.IsTrue(true);
            Assert.Fail();
        }

        [TestMethod]
        public void Bubble_Empty_ReturnsEmpty()
        {
            var arr = new int[] { };

            Sort.Bubble(arr);

            Assert.AreEqual(arr.Length, 0);
        }

        [TestMethod]
        public void Bubble_OneItem_ReturnsItem()
        {
            var arr = new int[] { 1 };

            Sort.Bubble(arr);

            Assert.AreEqual(arr.Length, 1);
        }

        [TestMethod]
        public void Bubble_TwoItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1 };
            var desired = new int[] { 1, 2 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_OddAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1 , 4 , 8 , 9 };
            var desired = new int[] { 1, 2, 4, 8, 9 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_EvenAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1, 4, 8, 9, 6 };
            var desired = new int[] { 1, 2, 4, 6, 8, 9 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_ReversedList_ReturnsItemsSorted()
        {
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var desired = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_SimilarItemList_ReturnsItemsSorted()
        {
            var arr = new int[] { 5, 6, 5, 6, 5, 6, 5, 6 };
            var desired = new int[] { 5, 5, 5, 5, 6, 6, 6, 6 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_SpecialMergeSortSortNumberList_ReturnsItemsSorted()
        {
            var arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            var desired = new int[] { 3, 9, 10, 27, 38, 43, 82 };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Bubble_ListWithBounds_ReturnsItemsSorted()
        {
            var arr = new int[] { 99999, Int32.MaxValue, Int32.MinValue, 10, 44, -1111, 0, 2, 2, 2, -1 };
            var desired = new int[] { Int32.MinValue, - 1111, -1, 0, 2, 2, 2, 10, 44, 99999, Int32.MaxValue };

            Sort.Bubble(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        //Selection sort
        [TestMethod]
        public void Selection_Empty_ReturnsEmpty()
        {
            var arr = new int[] { };

            Sort.Selection(arr);

            Assert.AreEqual(arr.Length, 0);
        }

        [TestMethod]
        public void Selection_OneItem_ReturnsItem()
        {
            var arr = new int[] { 1 };

            Sort.Selection(arr);

            Assert.AreEqual(arr.Length, 1);
        }

        [TestMethod]
        public void Selection_TwoItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1 };
            var desired = new int[] { 1, 2 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_OddAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1, 4, 8, 9 };
            var desired = new int[] { 1, 2, 4, 8, 9 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_EvenAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1, 4, 8, 9, 6 };
            var desired = new int[] { 1, 2, 4, 6, 8, 9 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_ReversedList_ReturnsItemsSorted()
        {
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var desired = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_SimilarItemList_ReturnsItemsSorted()
        {
            var arr = new int[] { 5, 6, 5, 6, 5, 6, 5, 6 };
            var desired = new int[] { 5, 5, 5, 5, 6, 6, 6, 6 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_SpecialMergeSortSortNumberList_ReturnsItemsSorted()
        {
            var arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            var desired = new int[] { 3, 9, 10, 27, 38, 43, 82 };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Selection_ListWithBounds_ReturnsItemsSorted()
        {
            var arr = new int[] { 99999, Int32.MaxValue, Int32.MinValue, 10, 44, -1111, 0, 2, 2, 2, -1 };
            var desired = new int[] { Int32.MinValue, -1111, -1, 0, 2, 2, 2, 10, 44, 99999, Int32.MaxValue };

            Sort.Selection(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        //Insetertion sort
        [TestMethod]
        public void Insertion_Empty_ReturnsEmpty()
        {
            var arr = new int[] { };

            Sort.Insertion(arr);

            Assert.AreEqual(arr.Length, 0);
        }

        [TestMethod]
        public void Insertion_OneItem_ReturnsItem()
        {
            var arr = new int[] { 1 };

            Sort.Insertion(arr);

            Assert.AreEqual(arr.Length, 1);
        }

        [TestMethod]
        public void Insertion_TwoItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1 };
            var desired = new int[] { 1, 2 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_OddAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1, 4, 8, 9 };
            var desired = new int[] { 1, 2, 4, 8, 9 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_EvenAmountOfItems_ReturnsItemsSorted()
        {
            var arr = new int[] { 2, 1, 4, 8, 9, 6 };
            var desired = new int[] { 1, 2, 4, 6, 8, 9 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_ReversedList_ReturnsItemsSorted()
        {
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var desired = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_SimilarItemList_ReturnsItemsSorted()
        {
            var arr = new int[] { 5, 6, 5, 6, 5, 6, 5, 6 };
            var desired = new int[] { 5, 5, 5, 5, 6, 6, 6, 6 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_SpecialMergeSortSortNumberList_ReturnsItemsSorted()
        {
            var arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            var desired = new int[] { 3, 9, 10, 27, 38, 43, 82 };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        [TestMethod]
        public void Insertion_ListWithBounds_ReturnsItemsSorted()
        {
            var arr = new int[] { 99999, Int32.MaxValue, Int32.MinValue, 10, 44, -1111, 0, 2, 2, 2, -1 };
            var desired = new int[] { Int32.MinValue, -1111, -1, 0, 2, 2, 2, 10, 44, 99999, Int32.MaxValue };

            Sort.Insertion(arr);

            CollectionAssert.AreEqual(arr, desired);
        }

        //MergeSort sort

            [TestMethod]
            public void MergeSort_Empty_ReturnsEmpty()
            {
                var arr = new int[] { };

                Sort.MergeSort(arr);

                Assert.AreEqual(arr.Length, 0);
            }

            [TestMethod]
            public void MergeSort_OneItem_ReturnsItem()
            {
                var arr = new int[] { 1 };

                Sort.MergeSort(arr);

                Assert.AreEqual(arr.Length, 1);
            }

            [TestMethod]
            public void MergeSort_TwoItems_ReturnsItemsSorted()
            {
                var arr = new int[] { 2, 1 };
                var desired = new int[] { 1, 2 };

                Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }

            [TestMethod]
            public void MergeSort_OddAmountOfItems_ReturnsItemsSorted()
            {
                var arr = new int[] { 2, 1, 4, 8, 9 };
                var desired = new int[] { 1, 2, 4, 8, 9 };

                Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }

            [TestMethod]
            public void MergeSort_EvenAmountOfItems_ReturnsItemsSorted()
            {
                var arr = new int[] { 2, 1, 4, 8, 9, 6 };
                var desired = new int[] { 1, 2, 4, 6, 8, 9 };

                Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }

            [TestMethod]
            public void MergeSort_ReversedList_ReturnsItemsSorted()
            {
                var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                var desired = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }

            [TestMethod]
            public void MergeSort_SimilarItemList_ReturnsItemsSorted()
            {
                var arr = new int[] { 5, 6, 5, 6, 5, 6, 5, 6 };
                var desired = new int[] { 5, 5, 5, 5, 6, 6, 6, 6 };

                Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }

            [TestMethod]
            public void MergeSort_SpecialMergeSortSortNumberList_ReturnsItemsSorted()
            {
                var input = new int[] { 38, 27, 43, 3, 9, 82, 10 };
                var expected = new int[] { 3, 9, 10, 27, 38, 43, 82 };

                var actual = Sort.MergeSort(input);

                CollectionAssert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void MergeSort_ListWithBounds_ReturnsItemsSorted()
            {
            var arr = new int[] { 99999, Int32.MaxValue, Int32.MinValue, 10, 44, -1111, 0, 2, 2, 2 , -1};
            //var arr = new int[] { 99999, 0, Int32.MaxValue,-1111, -1 };
            var desired = new int[] { Int32.MinValue,-1111, -1,  0, 2, 2, 2, 10, 44, 99999, Int32.MaxValue };
           // var desired = new int[] { -1111,-1, 0, 99999, Int32.MaxValue};

            Sort.MergeSort(arr);

                CollectionAssert.AreEqual(arr, desired);
            }
        }
}
