using System;
namespace Puissance4
{
    public class Computer : ManagePlayer
    {

         public Computer(int currentPlayer){
            this.currentPlayer = currentPlayer;
       }
        public override int play(){
            Random rnd = new Random();
            return rnd.Next(0, 7);
           
        }
    }
}