using CSharpPerformancePlaybook.Code;

string permsFilePath = @"C:\code\cspp\permsfile.txt";

// See https://aka.ms/new-console-template for more information
FilePermissionsChecker.LoadACL();

while (true)
{
    var result = FilePermissionsChecker.CheckPermissionFC(permsFilePath);
}
