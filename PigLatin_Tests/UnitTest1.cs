using PigLatin;

namespace PigLatin_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsVowelA()
        {
            bool actual = Translator.IsVowel('a');
            Assert.True(actual);
        }

        [Fact]
        public void TestIsVowelE()
        {
            bool actual = Translator.IsVowel('e');
            Assert.True(actual);
        }

        [Fact]
        public void TestIsVowelI()
        {
            bool actual = Translator.IsVowel('i');
            Assert.True(actual);
        }

        [Fact]
        public void TestIsVowelO()
        {
            bool actual = Translator.IsVowel('o');
            Assert.True(actual);
        }

        [Fact]
        public void TestIsVowelU()
        {
            bool actual = Translator.IsVowel('u');
            Assert.True(actual);
        }
                [Fact]
        public void TestIsVowelS()
        {
            bool actual = Translator.IsVowel('S');
            Assert.False(actual);
        }
        [Fact]
        public void TestIsVowelZ()
        {
            bool actual = Translator.IsVowel('Z');
            Assert.False(actual);
        }

        [Fact]
        public void StartsWithVowel()
        {
            bool actual = Translator.StartsWithVowel("apple");
            Assert.True(actual);
        }

        [Fact]
        public void StartsWithConsonant()
        {
            bool actual = Translator.StartsWithVowel("boolean");
            Assert.False(actual);
        }

        [Fact]
        public void TestNumCons1()
        {
            int actual = Translator.NumberofCons("banana");
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TestNumCons2()
        {
            int actual = Translator.NumberofCons("shout");
            Assert.Equal(2, actual);
        }

        [Fact]
        public void TestNumCons3()
        {
            int actual = Translator.NumberofCons("school");
            Assert.Equal(3, actual);
        }



        [Fact]
        public void TestPLVowel1()
        {
            string actual = Translator.PigLatinVowels("apple");
            Assert.Equal("appleyay", actual);
        }

        [Fact]
        public void TestPLVowel2()
        {
            string actual = Translator.PigLatinVowels("every");
            Assert.Equal("everyyay", actual);
        }

        [Fact]
        public void TestPLCons1()
        {
            string actual = Translator.PigLatinCons("school");
            Assert.Equal("oolschay", actual);
        }

        [Fact]
        public void TestPLCons2()
        {
            string actual = Translator.PigLatinCons("something");
            Assert.Equal("omethingsay", actual);
        }


        //public void TestPigLatinize1()
        //{
        //    string actual = Translator.PigLatinize("eat");
        //    Assert.Equal("eatyay", actual);
        //}

        //[Fact]

        //public void TestPigLatinize2()
        //{
        //    string actual = Translator.PigLatinize("banana");
        //    Assert.Equal("ananabay", actual);
        //}

        [Theory]
        [InlineData("eat", "eatyay")]
        [InlineData("banana", "ananabay")]
        public void TestPigLatinize(string value, string expected)
        {
            string actual = Translator.PigLatinize(value);
            Assert.Equal(expected, actual);
        }
    }




}