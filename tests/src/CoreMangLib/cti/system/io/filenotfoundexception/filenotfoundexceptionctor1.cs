using System;
using System.IO;
/// <summary>
///ctor
/// </summary>
public class FileNotFoundExceptionctor1
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new FileNotFoundException instance.");

        try
        {
            //Create the application domain setup information.
            FileNotFoundException myFileNotFoundException = new FileNotFoundException();
            if (myFileNotFoundException == null)
            {
                TestLibrary.TestFramework.LogError("001.1", "the FileNotFoundException ctor error occurred. ");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

    #endregion

    #endregion

    public static int Main()
    {
        FileNotFoundExceptionctor1 test = new FileNotFoundExceptionctor1();

        TestLibrary.TestFramework.BeginTestCase("FileNotFoundExceptionctor1");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

}
