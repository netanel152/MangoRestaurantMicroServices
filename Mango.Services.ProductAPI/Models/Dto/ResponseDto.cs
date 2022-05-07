namespace Mango.Services.ProductAPI.Models.DTO
{
    public class ResponseDto
    {
        public bool IsScuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
