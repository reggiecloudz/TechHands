namespace TechHands.Api.Data.Common
{
    public static class DataValidation
    {
        // Answer
        public const int AnswerTitleMinLength = 3;

        public const int AnswerTitleMaxLength = 50;

        public const int AnswerContentMinLength = 5;

        public const int AnswerContentMaxLength = 500;

        // AppUser
        public const int UserFirstNameMinLength = 2;

        public const int UserFirstNameMaxLength = 50;

        public const int UserLastNameMinLength = 2;

        public const int UserLastNameMaxLength = 50;

        public const int UsernameMinLength = 3;

        public const int UsernameMaxLength = 50;

        public const string UsernameAllowedSymbols = @"^[a-zA-Z0-9.]+$";

        public const int PasswordMinLength = 6;

        public const int PasswordMaxLength = 50;

        public const int AddressMinLength = 6;

        public const int AddressMaxLength = 50;

        public const int StylistDescriptionMinLength = 10;

        public const int StylistDescriptionMaxLength = 1000;

        // Appointment
        public const int AppointmentMaxLength = 500;

        // Article
        public const int ArticleTitleMinLength = 5;

        public const int ArticleTitleMaxLength = 100;

        public const int ArticleContentMinLength = 10;

        public const int ArticleContentMaxLength = 6000;

        // Brand
        public const int BrandNameMinLength = 2;

        public const int BrandNameMaxLength = 50;

        public const int BrandDescriptionMinLength = 6;

        public const int BrandDescriptionMaxLength = 1000;

        // Category
        public const int CategoryNameMaxLength = 50;

        // ChatGroup
        public const int ChatGroupNameMaxLength = 200;

        // Comment
        public const int CommentContentMinLength = 3;

        public const int CommentContentMaxLength = 1000;

        // JobType
        public const int JobTypeNameMaxLength = 50;

        // Order
        public const int OrderCommentMaxLength = 1000;

        // Expertise
        public const int ExpertiseNameMinLength = 5;

        public const int ExpertiseNameMaxLength = 100;

        public const int ExpertiseDescriptionMinLength = 10;

        public const int ExpertiseDescriptionMaxLength = 1000;

        public const string ExpertiseMinPrice = "10";

        public const string ExpertiseMaxPrice = "1000";

        // ExpertiseReview
        public const int ExpertiseReviewContentMinLength = 5;

        public const int ExpertiseReviewContentMaxLength = 1000;

        public const string ExpertiseReviewMinPoints = "1";

        public const string ExpertiseReviewMaxPoints = "5";

        // Product
        public const int ProductNameMinLength = 3;

        public const int ProductNameMaxLength = 60;

        public const int ProductDescriptionMinLength = 10;

        public const int ProductDescriptionMaxLength = 1000;

        public const string ProductMinPrice = "10";

        public const string ProductMaxPrice = "1000";

        // ProductReview
        public const int ProductReviewContentMaxLength = 1000;

        // Question
        public const int QuestionTitleMinLength = 3;
        public const int QuestionTitleMaxLength = 50;

        public const int QuestionContentMinLength = 5;
        public const int QuestionContentMaxLength = 1000;

        // StylistReview
        public const int StylistReviewContentMaxLength = 1000;

        // Verification Code
        public const int VerificationCodeMinLength = 6;

        public const int VerificationCodeMaxLength = 7;
    }
}
