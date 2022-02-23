namespace CSharpPerformancePlaybook.Code.Tests
{
    using Xunit;

    public class PermsTests
    {
        string permsFilePath = @"C:\code\cspp\permsfile.txt";

        [Fact]
        public void QDPerms()
        {
            Assert.False(FilePermissionsChecker.CheckPermissionQD(permsFilePath));
        }

        [Fact]
        public void ProperPerms()
        {
            Assert.False(FilePermissionsChecker.CheckPermission(permsFilePath));
        }

        [Fact]
        public void FileAclMethod()
        {
            FilePermissionsChecker.LoadACL();

            Assert.False(FilePermissionsChecker.CheckPermissionFC(permsFilePath));

            Assert.True(FilePermissionsChecker.CheckPermissionFC("file.txt"));

            Assert.False(FilePermissionsChecker.CheckPermissionFC("doesntexist.txt"));
        }
    }
}
