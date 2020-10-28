using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob;
        Job testJob2;
        string testJobString;
        

        [TestInitialize]
        public void CreateTestObjects()
        {
            testJob = new Job("product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob2 = new Job("product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJobString = testJob.ToString();
            
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            
            Assert.AreEqual(testJob.Name, "product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobssForEquality()
        {
            Assert.IsFalse(testJob.Equals(testJob2));
        }

        [TestMethod]
        public void TestJobToStringBeginsAndEndsWithEmptyLine()
        {
            Assert.IsTrue(testJobString.StartsWith(Environment.NewLine));
            Assert.IsTrue(testJobString.EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringReturnsLabelsAndDataForAllFields()
        {
            Assert.IsTrue(testJobString.Contains("ID: "));
            Assert.IsTrue(testJobString.Contains("Name: "));
            Assert.IsTrue(testJobString.Contains("Employer: "));
            Assert.IsTrue(testJobString.Contains("Location: "));
            Assert.IsTrue(testJobString.Contains("Position Type: "));
            Assert.IsTrue(testJobString.Contains("Core Competency: "));
            Assert.IsTrue(testJobString.Contains(testJob.Id.ToString()));
            Assert.IsTrue(testJobString.Contains(testJob.Name));
            Assert.IsTrue(testJobString.Contains(testJob.EmployerName.Value));
            Assert.IsTrue(testJobString.Contains(testJob.EmployerLocation.Value));
            Assert.IsTrue(testJobString.Contains(testJob.JobType.Value));
            Assert.IsTrue(testJobString.Contains(testJob.JobCoreCompetency.Value));
            Assert.AreEqual(testJobString.Split(Environment.NewLine).Length, 8);
        }

        [TestMethod]
        public void TestToStringEmptyFieldsReturnSpecialMessage()
        {
            Job job = new Job("Cleaner", new Employer("Shell Co."), new Location(""), new PositionType("Laundry Operator"), new CoreCompetency("Discretion"));
            string jobString = job.ToString();
            Assert.IsTrue(jobString.Contains("Data not available"));
        }

        [TestMethod]
        public void TestToStringToSeeIfJobExist()
        {
            Job job = new Job();
            string jobStr = job.ToString();

            Assert.AreEqual(jobStr, Environment.NewLine + "OOPS! This job does not seem to exist." + Environment.NewLine);
        }


    }
}
