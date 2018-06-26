using System;
using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutVariables : Koan
    {
        [Step(1)]
        public void VariablesAreNamedBucketsThatHoldASpecificTypeOfData()
        {
            string bucketHoldingTextData = "Hello String Variable.  Text data is called a 'string'";
            int bucketHoldingAnInteger = 0;   // holds integer data

            Assert.Equal(4, FILL_ME_IN);
            Assert.Equal("Hello String Variable.  Text data is called a 'string'", FILL_ME_IN);
        }

        [Step(2)]
        public void VariablesCanBeUninitialised_ButNeedsToBeGivenAValueBeforeBeenRead() {
            string greeting;   // greeting exists as a variable at this point
                
            greeting = "Whats up!";   // Try commenting this line out. You will get a compile error on the next line as you are reading it without a value ever been set

            Assert.Equal("Whats up!", FILL_ME_IN);
        }
        
        [Step(3)]
        public void FindOutTheTypeOfDataThatCanGoInAnyGivenVariable() 
        {
            string greeting = "Hidey ho";
            Type theTypeOfDataInTheGreetingVariable = greeting.GetType();  // Wow, this is a variable, that holds information about a .NET data type!

            Assert.Equal(typeof(string), FILL_ME_IN);
        }

        [Step(4)]
        public void TheContentsOfAVariableCanChange_ByAssigningANewValueToIt()
        {
            string greeting = "Konichiwa";

            greeting = "Hallo";
            Assert.Equal("Hallo", FILL_ME_IN);

            greeting = "Ciao";
            Assert.Equal("Ciao", FILL_ME_IN);
        }

        [Step(5)]
        public void ContentsOfAVariableCanBeCopiedToAnotherVariable() {
            int personsYearOfBirth = 1996;
            int anotherPersonsYearOfBirth = 2003;

            anotherPersonsYearOfBirth = personsYearOfBirth;
            personsYearOfBirth = 0;
            
            Assert.Equal(1996, FILL_ME_IN);
        }

        [Step(6)]
        public void YouCantPutTheWrongTypeOfDataInABucket()
        {
            bool shouldWeDoIt = true;
            
            // Try uncommenting any of the following lines.  They will all cause compiler errors becuase .NET is a strongly typed language!

            // shouldWeDoIt = 1;
            // shouldWeDoIt = "a string value";
            // shouldWeDoIt = shouldWeDoIt.GetType();
            
            Assert.Equal(true, shouldWeDoIt);
        }

        [Step(7)]
        public void VariablesNeedToBeDeclaredBeforeUsingThem()
        {

            // Uncommenting the following line will cause a compile error, as the variable is being used BEFORE it has been declared, and is not in scope
            
            // Assert.Equal(FILL_ME_IN, pleaseDeclareMeBeforeUsingMe);
            
            bool pleaseDeclareMeBeforeUsingMe = true;
            
            Assert.Equal(true, pleaseDeclareMeBeforeUsingMe);
        }
    }
}