using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD
{
    public class FizzBuzzGameTestsRefactored
    {
        [Theory,
            InlineData(1,"1"),
            InlineData(2,"2"),
            InlineData(3,"Fizz"),
            InlineData(5,"Buzz"),
            InlineData(15,"Fizz Buzz")]
        public void Should_return_values_according_to_Fizz_Buzz_game_rulez(int input, string expected)
        {
            //arrange
            var game = new FizzBuzzGame();

            //act
            var result = game.Play(input);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_invalid_argument_exception_when_input_is_lower_than_1()
        {
            //arrange
            var game = new FizzBuzzGame();

            //act and assert
            Assert.Throws<InvalidArgumentException>(() => game.Play(0));
        }


    }

    internal class InvalidArgumentException : Exception
    {
    }
}
