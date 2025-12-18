namespace NLWestStandings.Client.Classes
{
    public static class SVGLogo
    {
        public static string GetLogo(string? team_name, bool dark_mode = false)
        {
            if (string.IsNullOrWhiteSpace(team_name))
                return "";

            var entries = new (string Key, string Light, string Dark)[]
            {
                ("Arizona Diamondbacks", "ari_l.svg", "ari_d.svg"),
                ("D-backs", "ari_l.svg", "ari_d.svg"),
                ("Atlanta Braves", "atl_l.svg", "atl_d.svg"),
                ("Baltimore Orioles", "bal_l.svg", "bal_d.svg"),
                ("Boston Red Sox", "bos_l.svg", "bos_d.svg"),
                ("Chicago Cubs", "chc_l.svg", "chc_d.svg"),
                ("Chicago White Sox", "cws_l.svg", "cws_d.svg"),
                ("Cincinnati Reds", "cin_l.svg", "cin_d.svg"),
                ("Cleveland Guardians", "cle_l.svg", "cle_d.svg"),
                ("Colorado Rockies", "col_l.svg", "col_d.svg"),
                ("Detroit Tigers", "det_l.svg", "det_d.svg"),
                ("Houston Astros", "hou_l.svg", "hou_d.svg"),
                ("Kansas City Royals", "kc_l.svg", "kc_d.svg"),
                ("Los Angeles Angels", "laa_l.svg", "laa_d.svg"),
                ("Los Angeles Dodgers", "lad_l.svg", "lad_d.svg"),
                ("Miami Marlins", "mia_l.svg", "mia_d.svg"),
                ("Milwaukee Brewers", "mil_l.svg", "mil_d.svg"),
                ("Minnesota Twins", "min_l.svg", "min_d.svg"),
                ("New York Mets", "nym_l.svg", "nym_d.svg"),
                ("New York Yankees", "nyy_l.svg", "nyy_d.svg"),
                ("Oakland Athletics", "oak_l.svg", "oak_d.svg"),
                ("Athletics", "oak_l.svg", "oak_d.svg"),
                ("Philadelphia Phillies", "phi_l.svg", "phi_d.svg"),
                ("Pittsburgh Pirates", "pit_l.svg", "pit_d.svg"),
                ("San Diego Padres", "sd_l.svg", "sd_d.svg"),
                ("San Francisco Giants", "sf_l.svg", "sf_d.svg"),
                ("Seattle Mariners", "sea_l.svg", "sea_d.svg"),
                ("St. Louis Cardinals", "stl_l.svg", "stl_d.svg"),
                ("Tampa Bay Rays", "tb_l.svg", "tb_d.svg"),
                ("Texas Rangers", "tex_l.svg", "tex_d.svg"),
                ("Toronto Blue Jays", "tor_l.svg", "tor_d.svg"),
                ("Washington Nationals", "wsh_l.svg", "wsh_d.svg"),
            };

            foreach (var entry in entries)
            {
                if (entry.Key.Contains(team_name, System.StringComparison.InvariantCultureIgnoreCase))
                {
                    return dark_mode ? entry.Dark : entry.Light;
                }
            }

            return "";
        }
    }
}
