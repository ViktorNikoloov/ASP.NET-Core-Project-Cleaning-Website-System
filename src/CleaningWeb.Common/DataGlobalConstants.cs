namespace CleaningWeb.Common
{
    public static class DataGlobalConstants
    {
        public static class Common
        {
            public const int PhoneMaxLength = 11;

            public const int RangeStartedPoint = 0;

            public const int IntMaxValue = int.MaxValue;
        }

        public static class Appointment
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;
            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 50;
        }

        public static class Business
        {
            public const int MaxVacations = 5;
        }

        public static class Company
        {
            public const int AddressMaxLength = 100;

            public const int TitleMaxLength = 50;

            public const int DescriptionMaxLength = 1000;

            public const int MaxYearOfExperienced = 200;
        }
    }
}
