public class HashsetPractice
{
    public void CheckDupilcate()
    {
        HashSet<int> seen = new HashSet<int>();
        seen.Add(3);
        seen.Add(7);
        seen.Add(2);
        Console.WriteLine(2.GetHashCode());
        seen.Add(2);

        Console.WriteLine(seen.Contains(3)); //O(1)
        Console.WriteLine(seen.Contains(9)); //O(1)
        foreach (var item in seen)
        {
            Console.WriteLine(item);
        }
    }

    public void TestBucketLogic()
    {
        HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        string value = "John";

        int hash = value.GetHashCode();

        int bucketSize = 10;

        int bucket = Math.Abs(hash % bucketSize);

        Console.WriteLine($"Value: {value}");
        Console.WriteLine($"HashCode: {hash}");
        Console.WriteLine($"Bucket: {bucket}");

        Console.WriteLine(set.Add("john"));
        Console.WriteLine(set.Add("doe"));
        Console.WriteLine(set.Add("John"));

        HashSet<Employee> employees = new HashSet<Employee>();
        Console.WriteLine(employees.Add(new Employee { Id = 1 }));
        Console.WriteLine(employees.Add(new Employee { Id = 1 }));

    }
}

public class Employee
{
    public int Id { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Employee e && Id == e.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}