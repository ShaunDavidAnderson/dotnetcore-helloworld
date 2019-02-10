using System.Collections.Generic;

namespace Implementation
{
    public class ValuesRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "value2", "value3" };
        }

        public string GetById(int id)
        {
            return "value";
        }
    }
}
