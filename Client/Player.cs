using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int NumOfGames { get; set; }

        public TblPlayer convertToEntity()
        {
            TblPlayer tblPlayer = new TblPlayer();
            tblPlayer.Id = this.Id;
            tblPlayer.Name = this.Name.Trim();
            tblPlayer.Password = this.Password.Trim();
            tblPlayer.Email = this.Email.Trim();
            tblPlayer.NumOfGames = this.NumOfGames;
            return tblPlayer;
        }
    }
}
