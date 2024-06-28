using RailFenceCipher;

namespace RailFenceCipherTest
{
    public class RailFenceCiphererTest
    {
        RailFenceCipherer railFenceCipherer;
        [SetUp]
        public void Setup()
        {
            railFenceCipherer = new RailFenceCipherer();
        }

        [Test]
        [TestCase("WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN", 3)]
        public void RailEncodingTest(string inputString, string encyphered, int NumberOfRails)
        {
            Assert.AreEqual(encyphered, railFenceCipherer.Encode(inputString, NumberOfRails));
        }
    }
}