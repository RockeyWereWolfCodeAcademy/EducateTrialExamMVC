﻿namespace EducateTrialExamMVC.Exceptions
{
    public class AdminUserCreationFailedException : Exception
    {
        public AdminUserCreationFailedException()
        {
        }

        public AdminUserCreationFailedException(string? message) : base(message)
        {
        }
    }
}
