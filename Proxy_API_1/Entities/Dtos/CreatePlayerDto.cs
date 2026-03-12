namespace Proxy_API_1.Entities.Dtos
{
    public class CreatePlayerDto
    {
        public string PlayerName { get; set; } = string.Empty;
        public int PlayerNumber { get; set; } = 0;
        public bool isPlaying { get; set; } = false;
    }
}
