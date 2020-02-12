using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.v1_2
{
    public class OldMLBSportsFeedsClient
    {
        /// <summary>
        /// The base URL
        /// </summary>
        protected readonly string BASE_URL = "https://api.mysportsfeeds.com/v1.2";



        /// <summary>
        /// The HTTP worker
        /// </summary>
        private readonly HttpCommunicationWorker _httpWorker;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MySportsFeedsClient"/> class.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="version">The version.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public OldMLBSportsFeedsClient(string apiKey, string password)
        {
            _httpWorker = new HttpCommunicationWorker(this.BASE_URL, apiKey, password);
            InjectDependencies();
        }

        /// <summary>
        /// Injects the dependencies.
        /// </summary>
        private void InjectDependencies()
        {

            
            CurrentSeason = new Mlb.CurrentSeason(_httpWorker);
            DailyDfs = new Mlb.DailyDfs(_httpWorker);
            DailyGameSchedule = new Mlb.DailyGameSchedule(_httpWorker);
            DailyPlayerStats = new Mlb.DailyPlayerStats(_httpWorker);
            DivisionTeamStandings = new Mlb.DivisionTeamStandings(_httpWorker);
            FullGameSchedule = new Mlb.FullGameSchedule(_httpWorker);
            GameBoxScore = new Mlb.GameBoxScore(_httpWorker);
            GamePlayByPlay = new Mlb.GamePlayByPlay(_httpWorker);
            GameStartingLineup = new Mlb.GameStartingLineup(_httpWorker);
            LatestUpdates = new Mlb.LatestUpdates(_httpWorker);
            OverallTeamStandings = new Mlb.OverallTeamStandings(_httpWorker);
            PlayerGameLogs = new Mlb.PlayerGameLogs(_httpWorker);
            PlayerInjuries = new Mlb.PlayerInjuries(_httpWorker);
            PlayoffTeamStandings = new Mlb.PlayoffTeamStandings(_httpWorker);
            RosterPlayers = new Mlb.RosterPlayers(_httpWorker);
            Scoreboard = new Mlb.Scoreboard(_httpWorker);
            TeamGameLogs = new Mlb.TeamGameLogs(_httpWorker);
        }



        /// <summary>
        /// Gets the current season.
        /// </summary>
        /// <value>
        /// The current season.
        /// </value>
        public Mlb.CurrentSeason CurrentSeason { get; private set; }

        /// <summary>
        /// Gets the daily DFS.
        /// </summary>
        /// <value>
        /// The daily DFS.
        /// </value>
        public Mlb.DailyDfs DailyDfs { get; private set; }

        /// <summary>
        /// Gets the daily game schedule.
        /// </summary>
        /// <value>
        /// The daily game schedule.
        /// </value>
        public Mlb.DailyGameSchedule DailyGameSchedule { get; private set; }

        /// <summary>
        /// Gets the daily player stats.
        /// </summary>
        /// <value>
        /// The daily player stats.
        /// </value>
        public Mlb.DailyPlayerStats DailyPlayerStats { get; private set; }
        /// <summary>
        /// Gets the division team standings.
        /// </summary>
        /// <value>
        /// The division team standings.
        /// </value>
        public Mlb.DivisionTeamStandings DivisionTeamStandings { get; private set; }

        /// <summary>
        /// Gets the full game schedule.
        /// </summary>
        /// <value>
        /// The full game schedule.
        /// </value>
        public Mlb.FullGameSchedule FullGameSchedule { get; private set; }

        /// <summary>
        /// Gets the game box score.
        /// </summary>
        /// <value>
        /// The game box score.
        /// </value>
        public Mlb.GameBoxScore GameBoxScore { get; private set; }

        /// <summary>
        /// Gets the game play by play.
        /// </summary>
        /// <value>
        /// The game play by play.
        /// </value>
        public Mlb.GamePlayByPlay GamePlayByPlay { get; private set; }

        /// <summary>
        /// Gets the game starting lineup.
        /// </summary>
        /// <value>
        /// The game starting lineup.
        /// </value>
        public Mlb.GameStartingLineup GameStartingLineup { get; private set; }

        /// <summary>
        /// Gets the latest updates.
        /// </summary>
        /// <value>
        /// The latest updates.
        /// </value>
        public Mlb.LatestUpdates LatestUpdates { get; private set; }

        /// <summary>
        /// Gets the overall team standings.
        /// </summary>
        /// <value>
        /// The overall team standings.
        /// </value>
        public Mlb.OverallTeamStandings OverallTeamStandings { get; private set; }

        /// <summary>
        /// Gets the player game logs.
        /// </summary>
        /// <value>
        /// The player game logs.
        /// </value>
        public Mlb.PlayerGameLogs PlayerGameLogs { get; private set; }

        /// <summary>
        /// Gets the player injuries.
        /// </summary>
        /// <value>
        /// The player injuries.
        /// </value>
        public Mlb.PlayerInjuries PlayerInjuries { get; private set; }

        /// <summary>
        /// Gets the playoff team standings.
        /// </summary>
        /// <value>
        /// The playoff team standings.
        /// </value>
        public Mlb.PlayoffTeamStandings PlayoffTeamStandings { get; private set; }

        /// <summary>
        /// Gets the roster players.
        /// </summary>
        /// <value>
        /// The roster players.
        /// </value>
        public Mlb.RosterPlayers RosterPlayers { get; private set; }

        /// <summary>
        /// Gets the scoreboard.
        /// </summary>
        /// <value>
        /// The scoreboard.
        /// </value>
        public Mlb.Scoreboard Scoreboard { get; private set; }

        /// <summary>
        /// Gets the team game logs.
        /// </summary>
        /// <value>
        /// The team game logs.
        /// </value>
        public Mlb.TeamGameLogs TeamGameLogs { get; private set; }
    }
}