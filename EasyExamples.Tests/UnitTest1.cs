using Xunit;
using EasyExamples;

namespace EasyExamples.Tests
{
    public class PersonTests
    {
        [Fact]
        public void GetTotal_TestsSumNegative()
        {
            var persons = new Person[]
            {
                new Person { Value = -1 },
                new Person { Value = -1 }
            };
            var program = new Program();
            var resultLINQ = program.GetTotal(persons);
            var result = program.GetTotalOld(persons);
            Assert.Equal(resultLINQ, result);
        }
        
        [Fact]
        public void GetTotal_TestsSumNull()
        {
            var program = new Program();
            var resultLINQ = program.GetTotal(Array.Empty<Person>());
            var result = program.GetTotalOld(Array.Empty<Person>());
            Assert.Equal(resultLINQ, result);
        }
        
        [Fact]
        public void GetTotal_TestsSumPositive()
        {
            var program = new Program();
            var persons = new Person[]
            {
                new Person { Value = 2 },
                new Person { Value = 2 }
            };
            var resultLINQ = program.GetTotal(persons);
            var result = program.GetTotalOld(persons);
            Assert.Equal(resultLINQ, result);
        }
        
        [Fact]
        public void GetTotal_TestsSumPositiveAndNegative()
        {
            var program = new Program();
            var persons = new Person[]
            {
                new Person { Value = -4 },
                new Person { Value = 2 }
            };
            var resultLINQ = program.GetTotal(persons);
            var result = program.GetTotalOld(persons);
            Assert.Equal(resultLINQ, result);
        }
    }
}
