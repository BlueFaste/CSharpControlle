using System;
namespace Puissance4
{
    public abstract class ManagePlayer
    {
        public int currentPlayer {get; set;}
        

        public void setCurrentPlayer (){
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }
        
        public virtual int play(){
            return 1;
        }

        public bool checkIfWin (){
            return true;
        }
    }
}