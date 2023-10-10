namespace Library.Common
{
    public static class EntityValidationConstants
    {
        public static class Book
        {
            public const int TitleMaxLength = 50;

            public const int AuthorLength = 50; 

            public const int DescriptionLength = 5000;
        }

        public static class Category
        {
            public const int NameMaxLength = 50;
        }
    }
}
