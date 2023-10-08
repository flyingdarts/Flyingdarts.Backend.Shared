namespace Flyingdarts.Lambdas.Shared;

public class Metadata
{
    public GameDto Game { get; set; }
    public IOrderedEnumerable<PlayerDto> Players { get; set; }
    public Dictionary<string, Dictionary<int, List<DartDto>>> Darts { get; set; }
    public string NextPlayer { get; set; }
    public Dictionary<string, object> toDictionary()
    {
        var result = new Dictionary<string, object>
        {
            { "Game", Game },
            { "Players", Players },
            { "Darts", Darts },
            { "NextPlayer", NextPlayer }
        };

        return result;
    }
}
