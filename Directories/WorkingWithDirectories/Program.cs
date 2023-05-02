const string dir = "Test";

// cre4ate delete
if (!Directory.Exists(dir)) {
    Directory.CreateDirectory(dir);
}
else
{
    Directory.Delete(dir);
}