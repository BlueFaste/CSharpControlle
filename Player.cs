using System;
using System.Text;

namespace Puissance4
{
    public class Player : ManagePlayer{
       
        public override int play(){
            while (this.columnPlayed < 0 && this.columnPlayed > 6){
                Console.WriteLine($"Joueur {currentPlayer}, en quelle colonne jouez-vous ?");
                this.columnPlayed = Int32.Parse(Console.ReadLine());
            }
            return this.columnPlayed;
           
        }

    }
}