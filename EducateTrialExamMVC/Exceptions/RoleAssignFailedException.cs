namespace EducateTrialExamMVC.Exceptions
{
    public class RoleAssignFailedException : Exception
    {
        public RoleAssignFailedException()
        {
        }

        public RoleAssignFailedException(string? message) : base(message)
        {
        }
    }
}
