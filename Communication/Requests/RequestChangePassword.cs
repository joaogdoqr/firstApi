namespace FirstApi.Communication.Requests
{
    public class RequestChangePassword
    {
        public required string OldPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}
