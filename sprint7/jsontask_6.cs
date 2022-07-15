using System.Text.Json;
using System.Text.Json.Serialization;

public static string CreateGroups(List<Student> students, List<Group>groups)
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true
    };
    var studentsGroups = groups.GroupJoin(students,
                                            g => g.Name,
                                            s => s.GroupName,
                                            (group, studList) => new
                                            {
                                                group = group.Name,
                                                description = group.Description,
                                                rating = studList.Average(student => student.Rating),
                                                students = studList.Select(student => new
                                                {
                                                    FullName = student.Name,
                                                    AvgMark = student.Rating
                                                })
                                            });

    return JsonSerializer.Serialize(studentsGroups, options);
}
