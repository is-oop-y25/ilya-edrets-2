using Isu.Entities;
using Isu.Exceptions;
using Isu.Models;

namespace Isu.Services
{
    public class IsuService : IIsuService
    {
        private readonly Dictionary<string, Group> _groups;

        public IsuService()
        {
            _groups = new Dictionary<string, Group>();
        }

        public Group AddGroup(string groupName)
        {
            if (!Group.TryParse(groupName, out Group? group))
            {
                throw new InvalidGroupNameException(groupName);
            }

            _groups.Add(groupName, group!);

            return group!;
        }

        public Student AddStudent(Group @group, string name)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student? FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(string groupName)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Group? FindGroup(string groupName)
        {
            if (!_groups.ContainsKey(groupName))
            {
                return null;
            }

            return _groups[groupName];
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public void ChangeStudentGroup(Student student, Group newGroup)
        {
            throw new NotImplementedException();
        }
    }
}
