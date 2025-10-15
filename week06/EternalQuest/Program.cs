class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
                    string type = Console.ReadLine().ToLower();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int pts = int.Parse(Console.ReadLine());

                    if (type == "simple")
                        manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (type == "eternal")
                        manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (type == "checklist")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                    }
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    manager.ListGoals();
                    Console.Write("Which goal did you complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "4":
                    Console.WriteLine($"Current Score: {manager.GetScore()}");
                    break;

                case "5":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved.");
                    break;

                case "6":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    break;

                case "7":
                    running = false;
                    break;
            }
        }
    }
}
