namespace Dictionary
{
    public static class ExercisesDictionary
    {
        private static void Main()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();

            void Exercise1()
            {
                Console.WriteLine("Exercise 1.");

                var employees = new Dictionary<int, Student>
                 {
                { 1, new Student(4, "John") },
                { 2, new Student(5, "Henry") }
                  };
                foreach (KeyValuePair<int, Student> pair in employees)
                {
                    Console.WriteLine($"Student {pair.Value.Name}, estimation: {pair.Value.AverageRating}.");
                }
            }

            void Exercise2()
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
                string targetValue = dictionaryEnglishFranch.FirstOrDefault(pair => pair.Key == "music").Value;

                if (targetValue != null)
                {
                    Console.WriteLine(targetValue);
                }
                else
                {
                    Console.WriteLine("Key not found");
                }
            }

            void Exercise3()
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

                var keysToRemove = new HashSet<string>() { "book", "keys" };

                var filteredDict = listOfProducts
                    .Where(kvp => !keysToRemove
                    .Contains(kvp.Key))
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                var key = "game";
                var newValue = 700;

                AddOrUpdate(listOfProducts, key, newValue);
                foreach (var product in listOfProducts)
                {
                    Console.WriteLine($"{product.Key}: {product.Value}");
                }
                void AddOrUpdate(Dictionary<string, int> dic, string key, int newValue)
                {
                    int val;
                    if (dic.TryGetValue(key, out val))
                    {
                        // yay, value exists!
                        dic[key] = val + newValue;
                    }
                    else
                    {
                        // darn, lets add the value
                        dic.Add(key, newValue);
                    }
                }
            }

            void Exercise4()
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
                var sum = 0;
                foreach (var soldProduct in listOfProductsSold)
                {
                    sum += soldProduct.Value;
                }
                Console.WriteLine(sum);
            }
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