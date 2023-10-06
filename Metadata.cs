namespace Flyingdarts.Lambdas.Shared;

class Metadata
{
    public GameDto Game { get; set; }
    public IOrderedEnumerable<PlayerDto> Players { get; set; }
    public Dictionary<string, List<DartDto>> Darts { get; set; }

    public Dictionary<string, object> toDictionary()
    {
        var result = new Dictionary<string, object>
        {
            { "Game", Game },
            { "Players", Players },
            { "Darts", Darts }
        };

        return result;
    }
}
