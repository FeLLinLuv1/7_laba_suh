using _7_laba_suh;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class ArrayProcessorTests
{
    private ArrayProcessor _processor;

    [TestInitialize]
    public void Setup()
    {
        _processor = new ArrayProcessor();
    }

    [TestMethod]
    public void SortArray_ShouldSortArrayCorrectly()
    {
        int[] input = { 5, 1, 3 };
        int[] expected = { 1, 3, 5 };

        int[] result = _processor.SortArray(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void SortArray_ShouldThrowException_WhenArrayIsNull()
    {
        _processor.SortArray(null);
    }

    [TestMethod]
    public void FindMax_ShouldReturnMaximumValue()
    {
        int[] input = { 5, 7, 2, 9 };
        int expected = 9;

        int result = _processor.FindMax(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FindMax_ShouldThrowException_WhenArrayIsEmpty()
    {
        _processor.FindMax(new int[0]);
    }

    [TestMethod]
    public void CalculateAverage_ShouldReturnCorrectAverage()
    {
        int[] input = { 1, 2, 3, 4 };
        double expected = 2.5;

        double result = _processor.CalculateAverage(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FindMedian_ShouldReturnCorrectMedian_ForOddLengthArray()
    {
        int[] input = { 3, 1, 2 };
        double expected = 2;

        double result = _processor.FindMedian(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FindMedian_ShouldReturnCorrectMedian_ForEvenLengthArray()
    {
        int[] input = { 4, 2, 1, 3 };
        double expected = 2.5;

        double result = _processor.FindMedian(input);

        Assert.AreEqual(expected, result);
    }
}