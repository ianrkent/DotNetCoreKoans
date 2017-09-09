using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutImplicitAssignment : Koan
    {
        [Step(1)]
        public void ImplicitAssignment()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var name = "John";
            Assert.Equal(typeof(FillMeIn), name.GetType());

            //but only if it can. So this doesn't work
            //var array = null;
            
            //It also knows the type, so once the above is in place, this doesn't work:
            //name = 42;
        }

        [Step(2)]
        public void ImplicitArrayAssignmentWithSameTypes()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var names = new[] { "John", "Smith" };
            Assert.Equal(typeof(FillMeIn), names.GetType());

            //but only if it can. So this doesn't work
            //var array = new[] { "John", 1 };
        }

        [Step(3)]
        public void MultipleAssignmentsOnSingleLine()
        {
            //You can do multiple assignments on one line, but you 
            //still have to be explicit
            string firstName = "John", lastName = "Smith";
            Assert.Equal(FILL_ME_IN, firstName);
            Assert.Equal(FILL_ME_IN, lastName);
        }
    }
}