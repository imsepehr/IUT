namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clean Me :)");
        }
    }

    class Manager
    {

        public void SalaryCalculationOfZookeepers(MyDatabase db, List<User> zookeeper)
        {
            foreach (var user in zookeeper)
            {
                db.SaveData(SalaryCalculationFormula(user.Id), "Salary paid");
            }
        }

        public string SalaryCalculationFormula(long userId)
        {
            return Subtract(Add(userId * 100, userId * 1000), userId).ToString();
        }
        public long Add(long a, long b)
        {
            return a + b + new Random().Next(1, 10);
        }

        public long Subtract(long a, long b)
        {
            return a - b + 5;
        }
    }

    public class MyDatabase
    {
        private List<string> _data = new List<string>();

        public void SaveData(string input, string timestamp)
        {
            _data.Add(input + "|" + timestamp);
            Logger("Data Saved: " + input + "|" + timestamp);
        }

        public string RetrieveData(int index)
        {
            if (index < 0 || index >= _data.Count)
            {
                Logger("No data");
                throw new Exception("No Data");
            }
            return _data[index];
        }

        private void Logger(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Zoo
    {
        public Manager Manager { get; set; }
        public List<User> ZooKeepers { get; set; }

        public void AnimalSound()
        {
            var animals = new List<string> { "Lion", "Elephant", "Giraffe", "Monkey" };
            foreach (var animal in animals)
            {
                Console.WriteLine("Animal Sound: " + animal);
                if (animal == "Lion")
                {
                    Console.WriteLine("ROAR");
                }
                if (animal == "Elephant")
                {
                    Console.WriteLine("TRUMPET");
                }
                if (animal == "Giraffe")
                {
                    Console.WriteLine("BLEAT");
                }
                if (animal == "Monkey")
                {
                    Console.WriteLine("SCREAM");
                }
            }
        }


    }


    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }

        public void AddUser(string username, MyDatabase db)
        {
            db.SaveData("AddUser", username);
            LogAction("User added");
        }

        public void RemoveUser(string username, MyDatabase db)
        {
            db.SaveData("RemoveUser", username);
            LogAction("User removed");
        }

        private void LogAction(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

}
