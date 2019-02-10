using System.Collections.Generic;

namespace Implementation
{
    public class ValuesRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "value5", "value6" };
        }

        public string GetById(int id)
        {
            return "value";
        }
    }
}
