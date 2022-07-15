using System.Text.Json;
using System.Text.Json.Serialization;

class Department 
{
    public string Name { get; set; }
    public int Id { get; set; } 
    public Worker Manager { get; set; }

    public Department()
    {

    }

    public Department(string name, int id, Worker manager)
    {
        Name = name;
        Id = id;
        Manager = manager;
    }
}

class Worker 
{
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("Full name")]
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public Department Department { get; set; }

    public Worker()
    {

    }

    public Worker(string name, decimal salary, Department department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Serialize()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IgnoreNullValues = true
        };

        return JsonSerializer.Serialize<Worker>(this, options);
    }

    public static Worker Deserialize(string str)
    {
        return JsonSerializer.Deserialize<Worker>(str);
    }
}
