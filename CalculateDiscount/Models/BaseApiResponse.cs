namespace CalculateDiscount.Models
{
    public class BaseApiResponse<T>
    {
        public BaseApiResponse(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
