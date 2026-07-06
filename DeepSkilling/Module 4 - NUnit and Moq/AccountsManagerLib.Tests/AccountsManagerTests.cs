using NUnit.Framework;
using AccountsManagerLib;
using System;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountsManager();
        }

        [Test]
        public void ValidateUser_User11_ReturnsWelcomeMessage()
        {
            string actual = manager.ValidateUser("user_11", "secret@user11");

            Assert.That(actual, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void ValidateUser_User22_ReturnsWelcomeMessage()
        {
            string actual = manager.ValidateUser("user_22", "secret@user22");

            Assert.That(actual, Is.EqualTo("Welcome user_22!!!"));
        }

        [Test]
        public void ValidateUser_InvalidCredentials_ReturnsInvalidMessage()
        {
            string actual = manager.ValidateUser("user_11", "wrongpassword");

            Assert.That(actual, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void ValidateUser_EmptyUserId_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                manager.ValidateUser("", "secret@user11"));
        }

        [Test]
        public void ValidateUser_EmptyPassword_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                manager.ValidateUser("user_11", ""));
        }

        [Test]
        public void ValidateUser_BothEmpty_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                manager.ValidateUser("", ""));
        }

        [Test]
        public void ValidateUser_NullUserId_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                manager.ValidateUser(null, "secret@user11"));
        }

        [Test]
        public void ValidateUser_NullPassword_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                manager.ValidateUser("user_11", null));
        }
    }
}