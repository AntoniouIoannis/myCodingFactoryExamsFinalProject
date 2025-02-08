namespace CultureGR_MVC_ModelFirst.Exceptions
{
    public abstract class AppException : Exception
    {
        public string Code { get; set; }

        public AppException(string code, string message) : base(message)
        {
            Code = code;
        }
    }
}
