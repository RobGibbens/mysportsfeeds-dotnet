using System;
using Refit;

namespace MySportsFeeds.NetCore.v2_1.NFL.Request
{
    public class PlayersRequest
    {
        [AliasAs("season")]
        public string Season { get; set; }


        [AliasAs("date")]
        public DateTime? Date { get; set; }

        [AliasAs("team")]
        public string Team { get; set; }

        [AliasAs("force")]
        public bool? Force { get; set; }
        /*
        season={season-identifier} (filter on a specific season)
        date={date} (specify a date)
        team={list-of-teams} (filter teams)
        rosterstatus={list-of-roster-statuses} (filter roster statuses)
        player={list-of-players} (filter players)
        position={list-of-positions} (filter player positions)
        country={list-of-countries} (filter player countries of birth)
        sort={sort-specifier} (sort the feed's content)
        offset={offset-specifier} (filter results starting at the given offset)
        limit={limit-specifier} (limit the maximum # of results)
        force={force-if-not-modified} (force content)
        */
    }
}
