
using System.Globalization;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here

        [TestMethod] //1
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id, job2.Id, 1);  
        }

        [TestMethod] //2
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job3.Name.Equals("Product tester"));  
            Assert.IsTrue(job3.EmployerName.ToString().Equals("ACME"));
            Assert.IsTrue(job3.EmployerLocation.ToString().Equals("Desert"));
            Assert.IsTrue(job3.JobType.ToString().Equals("Quality control"));
            Assert.IsTrue(job3.JobCoreCompetency.ToString().Equals("Persistence"));
        } 

        [TestMethod] //3
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Id.Equals(job2.Id));
        }      
         
         [TestMethod] //4
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine) && job3.ToString().EndsWith(Environment.NewLine));
        } 

        [TestMethod] //5
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains("ID: " + job3.Id));
            Assert.IsTrue(job3.ToString().Contains("Name: " + job3.Name));
            Assert.IsTrue(job3.ToString().Contains("Employer: " + job3.EmployerName));
            Assert.IsTrue(job3.ToString().Contains("Location: " + job3.EmployerLocation));
            Assert.IsTrue(job3.ToString().Contains("Position Type: " + job3.JobType));
            Assert.IsTrue(job3.ToString().Contains("Core Competency: " + job3.JobCoreCompetency));
        } 

        [TestMethod] //6
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job4.ToString().Contains("Data not available"));
        } 
         

    }
    
}
