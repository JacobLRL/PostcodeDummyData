using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PostcodeJsonTest
{

    public class PostcodeTest
    {
        PostcodeService postcodeService = new PostcodeService();

        [Test]
        public void Status200Check()
        {
            Assert.AreEqual(200, postcodeService.postcodeDTO.PostcodeRoot.status);
        }

        [Test]
        public void QualityCheck() {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.Contains(list, postcodeService.postcodeDTO.PostcodeRoot.result.quality);
        }

        [Test]
        public void LatLongCheck() {
            var a = postcodeService.postcodeDTO.PostcodeRoot.result.latitude;
            var b = postcodeService.postcodeDTO.PostcodeRoot.result.longitude;
            Assert.IsTrue(a >= -90 && a <= 90);
            Assert.IsTrue(b >= -180 && b <= 180);
        }

        [Test]
        public void CountryCheck() {
            List<string> list = new List<string> { "England", "Scotland", "Wales", "Northern Ireland" };
            CollectionAssert.Contains(list, postcodeService.postcodeDTO.PostcodeRoot.result.country);
        }

        [Test]
        public void PostcodeCeck() {
            Assert.LessOrEqual(postcodeService.postcodeDTO.PostcodeRoot.result.postcode.Length, 8);
        }

        [Test]
        public void IncodeCheck() {
            string[] arr = postcodeService.postcodeDTO.PostcodeRoot.result.postcode.Split(' ');
            Assert.AreEqual(arr[1], postcodeService.postcodeDTO.PostcodeRoot.result.incode);
        }

        [Test]
        public void OutcodeCheck()
        {
            string[] arr = postcodeService.postcodeDTO.PostcodeRoot.result.postcode.Split(' ');
            Assert.AreEqual(arr[0], postcodeService.postcodeDTO.PostcodeRoot.result.outcode);
        }
    }
}
