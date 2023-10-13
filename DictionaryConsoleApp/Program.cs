namespace DictionaryConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            //Exercise1();
            Exercise2();
            //Exercise3();
            //Exercise4();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1.");

            var employees = new Dictionary<Student, int>
            {
                { new Student(4, "John"), 1},
                { new Student(5, "Henry"), 2 }
            };

            foreach (KeyValuePair<Student, int> pair in employees)
            {
                Console.WriteLine($"Student {pair.Key.Name}, estimation: {pair.Key.AverageRating}.");
            }
        }

        public static void Exercise2()
        {
            var dictionaryEnglishFranch = new Dictionary<string, string>(10)
            {
                    { "book", "livre" },
                    { "mouse", "souris" },
                    { "dictionary", "dictionnaire" },
                    { "notepad", "bloc-notes" },
                    { "word", "mot" },
                    { "time", "temps" },
                    { "music", "musique" },
                    { "game", "jeu" },
                    { "flower", "fleur" },
                    { "candles", "bougies" }
            };

            var input = Console.ReadLine();

            Console.WriteLine(GetTranslation(dictionaryEnglishFranch, input));

            string GetTranslation(Dictionary<string, string> dictionaryEnglishFranch, string input)
            {
                if (dictionaryEnglishFranch.ContainsKey(input))
                {
                    string translation = dictionaryEnglishFranch[input];
                    return translation;
                }
                else
                {
                    Console.WriteLine("Enter another word");
                    Exercise2();
                }
                return "";
            }
        }

        public static void Exercise3()
        {
            var listOfProducts = new Dictionary<string, int>(10)
            {
                    { "book", 500 },
                    { "mouse", 4300 },
                    { "dictionary", 3500 },
                    { "notepad", 990 },
                    { "keys", 600},
                    { "alarm сlock", 3400},
                    { "music record", 1500 },
                    { "game", 400},
                    { "flower", 2000 },
                    { "candles", 400}
            };

            var keysToRemove = new HashSet<string>() { "flower", "candles" };

            Remove(keysToRemove, listOfProducts);

            var key = "game";
            var newValue = 230;

            AddOrUpdate(listOfProducts, key, newValue);

            foreach (var product in listOfProducts)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            void AddOrUpdate(Dictionary<string, int> dictionary, string key, int newValue)
            {
                if (dictionary.TryGetValue(key, out var value))
                {
                    dictionary[key] = value + newValue;
                }
                else
                {
                    dictionary.Add(key, newValue);
                }
            }

            void Remove(HashSet<string> keysToRemove, Dictionary<string, int> listOfProducts)
            {
                var filteredDictionary = listOfProducts
                    .Where(pair => keysToRemove
                    .Contains(pair.Key))
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var product in filteredDictionary)
                {
                    listOfProducts.Remove(product.Key);
                }
            }
        }

        public static void Exercise4()
        {
            var listOfProductsSold = new Dictionary<string, int>(10)
            {
                    { "book", 4 },
                    { "mouse", 6 },
                    { "dictionary", 3 },
                    { "notepad", 10 },
                    { "keys", 2 },
                    { "alarm сlock", 5},
                    { "music record", 17 },
                    { "game", 7 },
                    { "flower", 30 },
                    { "candles", 14 }
            };

            Console.WriteLine(listOfProductsSold.Sum(soldProduct => soldProduct.Value));
        }
    }

    public class Student
    {
        public int AverageRating { get; }
        public string Name { get; }

        public Student(int averageRating, string name)
        {
            AverageRating = averageRating;
            Name = name;
        }
    }
}