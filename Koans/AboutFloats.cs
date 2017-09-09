using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutFloats : Koan
    {
        [Step(1)]
        public void UnquotedNumbersEndingInFAreFloats() {
            var f = 1f;

            Assert.Equal(typeof(FillMeIn), f.GetType());
        }

        [Step(2)]
        public void FloatsPreserveDecimalPoints() {
            float f = 1.5f;

            Assert.Equal(f, FILL_ME_IN);

            //Floating Point numbers are able to keep data beyond the decimal point
            //unlike Integers which are whole numbers.
            //Here f is set to 1.5, and retains the value of 1.5
            //without rounding or truncating the stored number.
        }

        [Step(3)]
        public void FloatingPointMathOutputsFloats() {
            var result = 1 * 2f; //One's an integer, one's a float (even though it's a whole number)!

            //what will the result type be?
            Assert.Equal(typeof(FillMeIn), result.GetType());

            //.NET Core kindly stores the result of the math in a float
            //so you don't lose the extra information in your floating point value
        }

        [Step(4)]
        public void FloatsHaveLimitedMaximumAndMinimumValues()
        {
            Assert.Equal(FILL_ME_IN, 3.40282347E+38f);
            Assert.Equal(FILL_ME_IN, -3.40282347E+38f);
        }

        [Step(5)]
        public void ValueLargerThanTheMaximumFloatThrows()
        {
            Assert.Throws(typeof(FillMeIn), () =>
            {
                var f = float.Parse("3.5E+38");
            });
        }
    }
}