using NUnit.Framework;
using CollectionsLib;
using System.Collections.Generic;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        [Test]
        public void GetEmployees_ReturnsAllEmployees()
        {
            List<Employee> employees = manager.GetEmployees();

            Assert.AreEqual(4, employees.Count);
        }

        [Test]
        public void GetEmployeesWhoJoinedInPreviousYears_ReturnsEmployees()
        {
            List<Employee> employees = manager.GetEmployeesWhoJoinedInPreviousYears();

            Assert.AreEqual(4, employees.Count);
        }
    }
}