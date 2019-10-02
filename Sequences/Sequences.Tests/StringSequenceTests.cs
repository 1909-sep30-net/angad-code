using System;
using System.Collections.Generic;
using Sequences.Library;
using Xunit;

namespace Sequences.Tests {
    public class StringSequenceTests {
        [Fact] //Attribute
        public void AddShouldAdd() {
            //Arrange ---- any set up necessary to prepare for the behavior to test
            var seq = new StringSequence();

            //Act ---- Do The Thing You Want To Test
            seq.Add("abc");

            //Assert ---- Verify That Behaviour was as Expected
            Assert.Equal(expected: "abc", actual: seq[0]);

        }
        [Fact]
        public void AddShouldAddInConsistenOrder() {
            //Arrange ---- any set up necessary to prepare for the behavior to test
            var seq = new StringSequence();

            //Act ---- Do The Thing You Want To Test
            seq.Add("abc");
            seq.Add("def");

            //Assert ---- Verify That Behaviour was as Expected
            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);

        }

        [Fact]
        public void AccessOutOfBoundsShouldThrow() {
            // arrange
            var seq = new StringSequence();

            // act, assert (that an exception is thrown when some code runs.)
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                var x = seq[0];
            });
        }

        [Fact]
        public void LongestStringShouldReturnLongest() {
            // arrange
            var seq = new StringSequence();
            seq.Add("");
            seq.Add("abc");
            seq.Add("0123456789");
            seq.Add("a");

            // act
            var longest = seq.LongestString();

            // assert
            Assert.Equal("0123456789", longest);
        }

    }
}
