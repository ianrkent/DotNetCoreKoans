using System;
using Xunit;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class AboutVariables : Koan
    {
        //Sometimes we will ask you to fill in the values
        [Step(0)]
        public void FillInValues() 
        {
            Assert.Equal(FILL_ME_IN, 1 + 1);
        }
        
        [Step(1)]
        public void VariablesAreNamedBucketsThatHoldASpecificTypeOfData()
        {
            string bucketHoldingTextData = "Hello String Variable.  Text data is called a 'string'";
            int bucketHoldingAnInteger = 4;   // holds integer data

            Assert.Equal(FILL_ME_IN, bucketHoldingAnInteger);
            Assert.Equal(FILL_ME_IN, bucketHoldingTextData);
        }

        [Step(2)]
        public void VariablesCanBeUninitialised_ButNeedsToBeGivenAValueBeforeBeenRead() {
            string greeting;   // greeting exists as a variable at this point
                
            greeting = "Whats up!";   // Try commenting this line out. You will get a compile error on the next line as you are reading it without a value ever been set

            Assert.Equal(FILL_ME_IN, greeting);
        }
        
        [Step(3)]
        public void FindOutTheTypeOfDataThatCanGoInAnyGivenVariable() 
        {
            string greeting = "Hidey ho";
            Type theTypeOfDataInTheGreetingVariable = greeting.GetType();  // Wow, this is a variable, that holds information about a .NET data type!

            Assert.Equal(typeof(FillMeIn), theTypeOfDataInTheGreetingVariable);
        }

        [Step(4)]
        public void TheContentsOfAVariableCanChange_ByAssigningANewValueToIt()
        {
            string greeting = "Konichiwa";

            greeting = "Hallo";
            Assert.Equal(FILL_ME_IN, greeting);

            greeting = "Ciao";
            Assert.Equal(FILL_ME_IN, greeting);
        }

        [Step(5)]
        public void ContentsOfAVariableCanBeCopiedToAnotherVariable() {
            int personsYearOfBirth = 1996;
            int anotherPersonsYearOfBirth = 2003;

            anotherPersonsYearOfBirth = personsYearOfBirth;
            Assert.Equal(FILL_ME_IN, anotherPersonsYearOfBirth);
        }

        [Step(6)]
        public void YouCantPutTheWrongTypeOfDataInABucket()
        {
            bool shouldWeDoIt = true;
            
            // Try uncommenting any of the following lines.  They will all cause compiler errors becuase .NET is a strongly typed language!

            // shouldWeDoIt = 1;
            // shouldWeDoIt = "a string value";
            // shouldWeDoIt = shouldWeDoIt.GetType();
            
            Assert.Equal(FILL_ME_IN, shouldWeDoIt);
        }

        [Step(7)]
        public void VariablesNeedToBeDeclaredBeforeUsingThem()
        {
            // Uncommenting the following line will cause a compile error, as the variable is being used BEFORE it has been declared, and is not in scope
            
            // Assert.Equal(FILL_ME_IN, pleaseDeclareMeBeforeUsingMe);
            
            bool pleaseDeclareMeBeforeUsingMe = true;
            
            Assert.Equal(FILL_ME_IN, pleaseDeclareMeBeforeUsingMe);
        }

        [Step(8)]
        public void ImplicityDetermineTheTypeOfTheVariable()
        {
            string variableDefinedAsString;                         // Explicitly defined as a string variable
            var variableImplicitlyDeterminedToBeAString = "Wotcha"; // Implicitly determined to be a string variable

            // The line below doesn't compile, as the compiler doesn't know what type of data will be stored in the variable
            // var stringVar;

            variableDefinedAsString = FILL_ME_IN;
            
            Assert.Equal(variableDefinedAsString, variableImplicitlyDeterminedToBeAString);
        }
        
        [Step(9)]
        public void MultipleAssignmentsOnSingleLine()
        {
            //You can do multiple assignments on one line, but only with explicit types! 
            string firstName = "John", lastName = "Smith";
            Assert.Equal(FILL_ME_IN, firstName);
            Assert.Equal(FILL_ME_IN, lastName);
        }
    }
}