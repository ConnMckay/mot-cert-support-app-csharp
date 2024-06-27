﻿namespace Timesheet.Tests.API
{
    internal class Login
    {
        public string email { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public Login(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}