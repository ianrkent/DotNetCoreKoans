using Xunit;
using DotNetCoreKoans.Engine;
using System;

namespace DotNetCoreKoans.Koans
{
    public class AboutControlStatements : Koan
    {
        [Step(1)]
        public void IfThenElseStatementsWithBrackets()
        {
            bool b;
            if (true)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            Assert.Equal(FILL_ME_IN, b);
        }

        [Step(2)]
        public void IfThenElseStatementsWithoutBrackets()
        {
            bool b;
            if(true)
                b = true;
            else
                b = false;

            Assert.Equal(FILL_ME_IN, b);

        }

        [Step(3)]
        public void IfThenStatementsWithBrackets()
        {
            bool b = false;
            if (true)
            {
                b = true;
            }

            Assert.Equal(FILL_ME_IN, b);
        }

        [Step(4)]
        public void IfThenStatementsWithoutBrackets()
        {
            bool b = false;
            if (true)
                b = true;

            Assert.Equal(FILL_ME_IN, b);
        }

        [Step(5)]
        public void WhyItsWiseToAlwaysUseBrackets()
        {
            bool b1 = false;
            bool b2 = false;

            int counter = 1;

            if (counter == 0)
                b1 = true;
                b2 = true;

			Assert.Equal(FILL_ME_IN, b1);
			Assert.Equal(FILL_ME_IN, b2);
        }

        [Step(6)]
        public void TernaryOperators()
        {
            Assert.Equal(FILL_ME_IN, (true ? 1 : 0));
            Assert.Equal(FILL_ME_IN, (false ? 1 : 0));
        }

       
        [Step(10)]
        public void WhileStatement()
        {
            int i = 1;
            int result = 1;
            while (i <= 3)
            {
                result = result + i;
                i += 1;
            }
            Assert.Equal(FILL_ME_IN, result);
        }

        [Step(11)]
        public void BreakStatement()
        {
            var counter = 1;
            var result = 1;
            
            while (true)
            {
                if (counter > 3) { break; }
                result = result + counter;
                counter += 1;    
            }
            
            Assert.Equal(FILL_ME_IN, result);
        }

        [Step(12)]
        public void ContinueStatement()
        {
            var counter = 0;
            var result = 0 ;
            
            while(counter < 10)
            {
                counter += 1;
                if ((counter % 2) == 0) { continue; }
                result += counter;
            }
            
            Assert.Equal(FILL_ME_IN, result);
        }

        [Step(13)]
        public void ForStatement()
        {
            var words = new[] { "fish", "and", "chips" };
            
            for (int i = 0; i < words.Length - 1; i++)
            {
                words[i] = (words[i].ToUpper());
            }
            
            Assert.Equal(FILL_ME_IN, words);
        }

        [Step(14)]
        public void ForEachStatement()
        {
            var words = new [] { "fish", "and", "chips" };
            string result = string.Empty;
            
            foreach (var word in words)
            {
                result += word;
            }
            
            Assert.Equal(FILL_ME_IN, words);
            Assert.Equal(FILL_ME_IN, result);
        }
    }
}