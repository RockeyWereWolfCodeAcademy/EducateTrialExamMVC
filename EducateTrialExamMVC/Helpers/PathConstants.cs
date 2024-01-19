namespace EducateTrialExamMVC.Helpers
{
    public static class PathConstants
    {
        public static string RootPath { get; set; }
        public static string InstructorImagePath => Path.Combine("savedimages", "instructors");
    }
}
