using System;
using System.Text;

namespace Puissance4
{
    public class Player : ManagePlayer{
       
        public Player(int currentPlayer){
            this.currentPlayer = currentPlayer;
       }
        public override int play(){
            int columnPlayed = -1;
            while (columnPlayed < 0 || columnPlayed > 6){
                Console.WriteLine($"Joueur {currentPlayer}, en quelle colonne jouez-vous ?");
                columnPlayed = Int32.Parse(Console.ReadLine());
            }
            return columnPlayed;
           
        }

    }
}