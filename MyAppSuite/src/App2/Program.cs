HashSet<string> namesHashSet = new HashSet<string>();

// Adding elements to the set
namesHashSet.Add("John");
namesHashSet.Add("Jane");
namesHashSet.Add("Alice");

// Checking if an element exists
bool hasAlice = namesHashSet.Contains("Alice"); // O(1) membership check

// Removing an element
namesHashSet.Remove("John");

// Iterating over the elements
foreach (string name in namesHashSet)
{
    Console.WriteLine(name);
}
