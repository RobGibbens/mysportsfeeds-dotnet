namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class StatsBase
    {
        public AtBatStats AtBats { get; set; }
        public Runs Runs { get; set; }
        public Hits Hits { get; set; }
        public Homeruns Homeruns { get; set; }
        public EarnedRuns EarnedRuns { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
    }
}
