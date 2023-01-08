namespace PlayGround;
// using System.Collections;
// using System.Collections.Generic;

public class Player : IComparable{
    private string Name;
    private int Runs;
    private int Matches;
    private double AvgRunRate;

    public Player(string nm, int rn, int mtch, double avgrn){
        this.Name = nm;
        this.Runs = rn;
        this.Matches = mtch;
        this.AvgRunRate = avgrn;
    }

    public int CompareTo(object? obj){
        Player anotherPlayer = (Player)obj;
        if(this.Runs > anotherPlayer.Runs){
            return 1;
        }else if(this.Runs < anotherPlayer.Runs){
            return -1;
        }else{
            return 0;
        }
    }

    public override string ToString()
    {
        return "Player Name : "+this.Name+", Total Runs : "+this.Runs+", Total Matches : "+this.Matches+", Runrate : "+this.AvgRunRate;
    }
}