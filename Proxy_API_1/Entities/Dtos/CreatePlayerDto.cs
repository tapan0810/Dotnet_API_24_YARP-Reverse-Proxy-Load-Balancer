namespace Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Dtos
{
    public class CreatePlayerDto
    {
        public string PlayerName { get; set; } = string.Empty;
        public int PlayerNumber { get; set; } = 0;
        public bool isPlaying { get; set; } = false;
    }
}
