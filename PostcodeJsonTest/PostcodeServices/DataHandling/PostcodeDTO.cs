using System;
using Newtonsoft.Json;

namespace PostcodeJsonTest
{
    class PostcodeDTO
    {
        public Rootobject PostcodeRoot { get; set; }
        public Result Result { get; set; }

        public void DeserializePostcode(string postcodeResponse) {
            PostcodeRoot = JsonConvert.DeserializeObject<Rootobject>(postcodeResponse);
            Result = PostcodeRoot.result;
        }
    }
}
