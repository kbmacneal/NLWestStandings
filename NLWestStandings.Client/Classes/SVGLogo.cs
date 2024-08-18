namespace NLWestStandings.Client.Classes
{
    public static class SVGLogo
    {
        public static string GetLogo(string? team_name)
        {
            try
            {
                return team_name switch
                {
                    "Arizona Diamondbacks" => "ari_l.svg",
                    "Atlanta Braves" => "atl_l.svg",
                    "Baltimore Orioles" => "bal_l.svg",
                    "Boston Red Sox" => "bos_l.svg",
                    "Chicago Cubs" => "chc_l.svg",
                    "Chicago White Sox" => "cws_l.svg",
                    "Cincinnati Reds" => "cin_l.svg",
                    "Cleveland Guardians" => "cle_l.svg",
                    "Colorado Rockies" => "col_l.svg",
                    "Detroit Tigers" => "det_l.svg",
                    "Houston Astros" => "hou_l.svg",
                    "Kansas City Royals" => "kc_l.svg",
                    "Los Angeles Angels" => "laa_l.svg",
                    "Los Angeles Dodgers" => "lad_l.svg",
                    "Miami Marlins" => "mia_l.svg",
                    "Milwaukee Brewers" => "mil_l.svg",
                    "Minnesota Twins" => "min_l.svg",
                    "New York Mets" => "nym_l.svg",
                    "New York Yankees" => "nyy_l.svg",
                    "Oakland Athletics" => "oak_l.svg",
                    "Philadelphia Phillies" => "phi_l.svg",
                    "Pittsburgh Pirates" => "pit_l.svg",
                    "San Diego Padres" => "sd_l.svg",
                    "San Francisco Giants" => "sf_l.svg",
                    "Seattle Mariners" => "sea_l.svg",
                    "St. Louis Cardinals" => "stl_l.svg",
                    "Tampa Bay Rays" => "tb_l.svg",
                    "Texas Rangers" => "tex_l.svg",
                    "Toronto Blue Jays" => "tor_l.svg",
                    "Washington Nationals" => "wsh_l.svg",
                    _ => "",
                };
            }
            catch (Exception)
            {
                return "";
            }
            
        }
    }
}
