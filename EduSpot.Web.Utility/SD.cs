namespace EduSpot.Web.Utility
{
    public class SD
    {
        public static string UniversityAPIBase { get; set; }
        public static string MajorAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }



        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}
