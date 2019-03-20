using System;
using Newtonsoft.Json.Linq;

namespace PostcodeJsonTest
{
    class PostcodeService
    {
        public PostcodeReader reader = new PostcodeReader();
        public PostcodeDTO postcodeDTO = new PostcodeDTO();
        public JObject postcodeJson;

        public PostcodeService() {
            postcodeDTO.DeserializePostcode(reader.ReadJson(@"C:\Users\tech-w74a\source\repos\PostcodeJsonTest\PostcodeJsonTest\Resources\DummyData.json"));
            postcodeJson = JObject.Parse(reader.ReadJson(@"C:\Users\tech-w74a\source\repos\PostcodeJsonTest\PostcodeJsonTest\Resources\DummyData.json"));
        }
    }
}
