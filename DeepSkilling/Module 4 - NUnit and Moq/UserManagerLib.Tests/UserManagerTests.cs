using NUnit.Framework;
using UserManagerLib;
using System;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        public void CreateUser_ValidPANCard_UserCreatedSuccessfully()
        {
            User newUser = new User
            {
                PANCardNo = "ABCDE1234F"
            };

            Assert.DoesNotThrow(() => user.CreateUser(newUser));
        }

        [Test]
        public void CreateUser_NullPANCard_ThrowsNullReferenceException()
        {
            User newUser = new User
            {
                PANCardNo = null
            };

            Assert.That(
                () => user.CreateUser(newUser),
                Throws.TypeOf<NullReferenceException>()
                      .With.Message.EqualTo("Invalid Pan Card Number"));
        }

        [Test]
        public void CreateUser_EmptyPANCard_ThrowsNullReferenceException()
        {
            User newUser = new User
            {
                PANCardNo = ""
            };

            Assert.That(
                () => user.CreateUser(newUser),
                Throws.TypeOf<NullReferenceException>()
                      .With.Message.EqualTo("Invalid Pan Card Number"));
        }

        [Test]
        public void CreateUser_InvalidLengthPANCard_ThrowsFormatException()
        {
            User newUser = new User
            {
                PANCardNo = "ABC123"
            };

            Assert.That(
                () => user.CreateUser(newUser),
                Throws.TypeOf<FormatException>()
                      .With.Message.EqualTo("Pan Card Number Should contain only 10 characters"));
        }
    }
}