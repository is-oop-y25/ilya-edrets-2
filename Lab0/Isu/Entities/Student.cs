namespace Isu.Entities;

public class Student
{
    private int _id;

    public Student(int id, string firstName, string lastName, Group group)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Group = group;
    }

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Id));
            }

            _id = value;
        }
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Group? Group { get; set; }
}
