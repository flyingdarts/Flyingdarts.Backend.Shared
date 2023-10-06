namespace Flyingdarts.Lambdas.Shared;

public class GameDto
{
    public String Id { get; set; }
    public GameTypeDto Type { get; set; }
    public GameStatusDto Status { get; set; }
    public int PlayerCount { get; set; }
    public X01GameSettingsDto X01 { get; set; }
}
