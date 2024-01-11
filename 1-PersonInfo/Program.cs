



using _1_PersonInfo;

while (true)
{
    try
    {
        int execute = TransfareInformation.Run();
        switch (execute)
        {
            case 1:
                {
                    var name = TransfareInformation.GetString("enter name");
                    var LastName = TransfareInformation.GetString("ente last name");
                    TransfareInformation.SavePersonInfo(name, LastName);
                    var fullName = TransfareInformation.GetFullName(name, LastName);
                    Console.WriteLine($"------------\n{fullName}\n------------");
                    break;
                }
            case 0:
                {
                    Environment.Exit(0);
                    break;
                }
            default:
                {
                    TransfareInformation.Run();
                    break;
                }
        }
    }
    catch (Exception ex)
    {
        TransfareInformation.Error(ex.Message);
    }
}

