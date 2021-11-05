using System;
namespace Puissance4
{
    public class Computer : ManagePlayer
    {
        public override int play(){
            while (this.columnPlayed < 0 && this.columnPlayed > 6){
                Random rnd = new Random();
                this.columnPlayed= rnd.Next(0, 7);
            }
            return this.columnPlayed;
           
        }
    }
}