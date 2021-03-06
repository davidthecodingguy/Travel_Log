using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveAndRetrieveFilesTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #4) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #1: Tests to ensure the previous locations save file exists without having to run the program or check the computer's memory manually (Part of Feature #4)
        //PLEASE NOTE: Test Type #1 will fail if you have not made an error or attempted to log a location
        [Test]
        public void EnsurePreviousLocationsFileExists()
        {
            File.Exists("PreviousLocations.csv");
            Assert.IsTrue(File.Exists("PreviousLocations.csv"));
        }
        //Tests to ensure the previous errors save file exists without having to run the program or check the computer's memory manually (Part of Feature #4)
        [Test]
        public void EnsurePreviousErrorsFileExists()
        {
            File.Exists("DailyTravelLogErrors.txt");
            Assert.IsTrue(File.Exists("DailyTravelLogErrors.txt"));
        }
        //TEST TYPE #2: Tests to ensure the program is writing to a csv file stored on the computer, like is done in the location logging feature, without having to run the program or check the computer's memory manually (Part of Feature #4)
        [Test]
        public void EnsureWriteToCsvFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.csv");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            Assert.IsNotEmpty(File.ReadAllText("ProgramTestFile.csv"));
            //Deletes file to ensure future test accuracy
            File.Delete("ProgramTestFile.csv");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.csv"));
        }
        //Tests to ensure the program is writing to a txt file stored on the computer, like is done in the error logging feature, without having to run the program or check the computer's memory manually (Part of Feature #4)
        [Test]
        public void EnsureWriteToTxtFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.txt");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            Assert.IsNotEmpty(File.ReadAllText("ProgramTestFile.txt"));
            //Deletes file to ensure future test accuracy
            File.Delete("ProgramTestFile.txt");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.txt"));
        }
        //TEST TYPE #3: Tests to ensure the program is reading from the correct csv file stored on the computer, like is done in the previous locations display feature (Part of Feature #4)
        [Test]
        public void EnsureReadCsvFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.csv");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            StreamReader teststreamReader = new StreamReader("ProgramTestFile.csv");
            Assert.IsNotEmpty(File.ReadLines("ProgramTestFile.csv"));
            Console.WriteLine(teststreamReader.ReadLine());
            Assert.IsNotEmpty(teststreamReader.ReadLine());
            teststreamReader.Close();
            //Deletes file to ensure future test accuracy
            File.Delete("ProgramTestFile.csv");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.csv"));
        }
        //Tests to ensure the program is reading from the correct txt file stored on the computer, like is done in the previous errors display feature (Part of Feature #4)
        [Test]
        public void EnsureReadTxtFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.txt");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            StreamReader teststreamReader = new StreamReader("ProgramTestFile.txt");
            Console.WriteLine(teststreamReader.ReadLine());
            Assert.IsNotEmpty(teststreamReader.ReadLine());
            teststreamReader.Close();
            //Deletes file to ensure future test accuracy
            File.Delete("ProgramTestFile.txt");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.txt"));
        }
        
    }
}