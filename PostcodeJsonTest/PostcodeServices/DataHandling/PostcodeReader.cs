using System;
using System.IO;

namespace PostcodeJsonTest
{
    class PostcodeReader
    {
        public string Json;
        public string ReadJson(string filename)
        {
            using (var stream = new StreamReader(filename))
            {
                Json = stream.ReadToEnd();
            }
            return Json;
        }
    }
}
