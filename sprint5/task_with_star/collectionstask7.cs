using System.Collections.Generic;

class Student 
{
    public int Id { get; }
    public string Name { get; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public static HashSet<Student> GetCommonStudents(List<Student> list1, List<Student> list2 )
    {
        var students = new HashSet<Student>(list1);
        students.IntersectWith(list2);
        
        return students;
    }

    public override bool Equals(object obj)
    {
        return this.Equals(obj as Student);
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(this.Id, this.Name);
    }
    
    public bool Equals(Student student)
    {
        if (student == null)
        {
            return false;
        }
        
        return object.Equals(student.Id, this.Id) && student.Name == this.Name;
    }
}
