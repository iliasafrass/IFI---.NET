using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            IEnumerable<string> result =
                from s in strings
                where s.StartsWith(startCharacter) && s.EndsWith(endCharacter)
                select s;
            return result;
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            IEnumerable<int> result =
                from number in numbers
                where number > limit
                
                select number;
            return result;
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {

            IEnumerable<int> numbersTrie =
            from number in numbers
            orderby number descending
            select number;

            return numbersTrie.Take(limit);
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            IEnumerable<string> result =
            from file in files
            select file.ToLower().Split('.')[1];

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string res in result) {
                if (!dict.ContainsKey(res))
                {
                    dict.Add(res, 1);
                }
                else
                {
                    dict[res]++;
                }
            }
            return dict;
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            throw new NotImplementedException();
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
