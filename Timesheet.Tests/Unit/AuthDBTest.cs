using Timesheet.DB;
using Timesheet.Models.Auth;

namespace Timesheet.Tests.Unit
{
    internal class AuthDBTest
    {
        private AuthDB _authDB = new AuthDB();

        [SetUp]
        public void Setup()
        {
            PrepareDB prepareDb = new PrepareDB();
            prepareDb.SeedUsers();
        }

        [Test]
        public void CheckLoginReturnsPostiveResult()
        {
            LoginResult loginResult = _authDB.CheckLogin("admin@test.com", "password123");
            Assert.That(loginResult.isUser, Is.True);
        }
    }
}
