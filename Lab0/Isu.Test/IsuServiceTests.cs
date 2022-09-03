using Isu.Exceptions;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTests
{
    private readonly IsuService service;

    public IsuServiceTests()
    {
        service = new IsuService();
    }

    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent()
    {
    }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException()
    {
    }

    [Theory]
    [InlineData("asd")]
    [InlineData("aasdsd")]
    [InlineData("123asd")]
    public void CreateGroupWithInvalidName_ThrowException(string invalidName)
    {
        Assert.Throws<InvalidGroupNameException>(() => service.AddGroup(invalidName));
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged() { }
}