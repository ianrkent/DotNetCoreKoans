using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using DotNetCoreKoans.Engine;


namespace DotNetCoreKoans.Koans
{
    public class AboutArrays : Koan
    {
        [Step(1)]
        public void CreatingArrays()
        {
            var empty_array = new object[] { };
            Assert.Equal(typeof(FillMeIn), empty_array.GetType());
            Assert.Equal(FILL_ME_IN, empty_array.Length);
        }

        [Step(2)]
        public void ArrayLiterals()
        {
            //You don't have to specify a type if the arguments can be inferred
            var array = new [] { 42 };
            Assert.Equal(typeof(int[]), array.GetType());
            Assert.Equal(new int[] { 42 }, array);

            //Are arrays 0-based or 1-based?
            Assert.Equal(42, array[FILL_ME_IN]);
        }

        [Step(3)]
        public void AccessingArrayElements()
        {
            var array = new[] { "peanut", "butter", "and", "jelly" };

            Assert.Equal(FILL_ME_IN, array[0]);
            Assert.Equal(FILL_ME_IN, array[3]);
        }

        [Step(4)]
        public void ArraysHaveUpperAndLowerRanges()
        {
            var fibonacci = new[] {1, 1, 2, 3, 5, 8};
            
            Assert.Equal(FILL_ME_IN, fibonacci.Length);
            Assert.Equal(FILL_ME_IN, fibonacci.GetUpperBound(0));
            Assert.Equal(FILL_ME_IN, fibonacci.GetLowerBound(0));

            Assert.Throws(typeof(FillMeIn), () => fibonacci[99]);
        }
    }
}