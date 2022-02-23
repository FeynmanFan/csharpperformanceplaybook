namespace CSharpPerformancePlaybook.Code
{
    using System.Security.AccessControl;

    public static class FilePermissionsChecker
    {
        private static Dictionary<string, bool> acl = new Dictionary<string, bool>();

        /// <summary>
        /// Loads the ACL file once at startup for better performance
        /// </summary>
        /// <param name="aclPath">The optional path to the ACL</param>
        public static void LoadACL(string aclPath = @"C:\code\cspp\acl.txt")
        {
            var lines = File.ReadAllLines(aclPath);

            foreach (var line in lines)
            {
                var lineArray = line.Split('\t');

                if (lineArray.Length < 2 || !int.TryParse(lineArray[1], out int allowed))
                {
                    continue;
                }
    
                acl.Add(lineArray[0], allowed == 1);
            }
        }

        /// <summary>
        /// Checks the file ACL for a given path based on the contents of an ACL file.
        /// </summary>
        /// <param name="path">The file to check</param>
        /// <param name="ACLPath">The path to the ACL file</param>
        /// <returns>Whether or not the user has permission</returns>
        public static bool CheckPermissionFC(string path)
        {
            var fileName = Path.GetFileName(path);

            return acl.FirstOrDefault(x => x.Key == fileName).Value;
        }

        /// <summary>
        /// Quick and dirty read permission checker that throws an exception if false
        /// </summary>
        /// <param name="path">The path to the resource</param>
        /// <returns>Whether or not the user has permission</returns>
        public static bool CheckPermissionQD(string path)
        {
            try
            {
                var contents = File.ReadAllBytes(path);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        /// <summary>
        /// Reads the ACL the proper way and determines whether the user has the specified permission
        /// </summary>
        /// <param name="path">The path to the resource</param>
        /// <param name="permission">The permission you desire to check</param>
        /// <returns>Whether or not the user has permission</returns>
        public static bool CheckPermission(string path, FileSystemRights permission = FileSystemRights.Read)
        {
            var allow = false;
            var deny = false;

            var acl = FileSystemAclExtensions.GetAccessControl(new DirectoryInfo(path));
            if (acl == null)
            { 
                return false; 
            }

            var accessRules = acl.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            if (accessRules == null)
            {
                return false;
            }

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if ((permission & rule.FileSystemRights) != permission)
                {
                    continue;
                }

                if (rule.AccessControlType == AccessControlType.Allow)
                { 
                    allow = true; 
                }
                else if(rule.AccessControlType == AccessControlType.Deny)
                { 
                    deny = true;
                }
            }

            return allow && !deny;
        }
    }
}
