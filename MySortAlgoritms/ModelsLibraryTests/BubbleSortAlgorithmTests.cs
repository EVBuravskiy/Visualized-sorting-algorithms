using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Tests
{
    [TestClass()]
    public class BubbleSortAlgorithmTests
    {
        //Arrange
        int count = 1000;
        List<int> expectedResult = new List<int>();
        BubbleSortAlgorithm<int> bubbleSort = new BubbleSortAlgorithm<int>();
        ////Worst case
        //for (int i = count; i > 0; i--)
        //{
        //    bubbleSort.Elements.Add(i);
        //}

        //Normal case
        Random random = new Random();
        for (int i = 0; i < count; i ++)
        {
            bubbleSort.Elements.Add(random.Next(1, 1000));
        }

    ////Best case
    //for (int i = 0; i < count; i++)
    //{
    //    bubbleSort.Elements.Add(i);
    //}

    expectedResult.AddRange(bubbleSort.Elements);
            expectedResult.Sort();

            //Act
            int countOfIteration = bubbleSort.Sort();

    //Assert
    Assert.AreEqual(expectedResult.Count, bubbleSort.Elements.Count);
            for (int i = 0; i<expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], bubbleSort.Elements[i]);
            }
    }
}