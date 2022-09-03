using Isu.Models;

namespace Isu.Entities;

public class Group
{
    private Group(string groupName, CourseNumber courseNumber)
    {
        GroupName = groupName;
        CourseNumber = courseNumber;
        Students = new List<Student>();
    }

    public string GroupName { get; set; }

    public CourseNumber CourseNumber { get; set; }

    public List<Student> Students { get; }

    public static bool TryParse(string groupName, out Group? group)
    {
        group = null;
        if (!groupName.StartsWith("M"))
        {
            return false;
        }

        group = new Group(groupName, CourseNumber.First);

        return true;
    }
}