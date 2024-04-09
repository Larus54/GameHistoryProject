using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHistoryProject.Extensions.ListGame_Type
{
    
    internal class games
    {
        public string game_name { get; set; }
        public int game_id { get; set; }
        public string game_description { get; set; }
        public string game_photo_path { get; set; }
        public string game_developer { get; set; }
        
    }

    internal class list_games
    {
        public List<games> games;
    }
}
