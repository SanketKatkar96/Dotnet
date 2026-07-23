namespace Worldcup;

//content 
public class Player
{

    //chagnes done by Ravi Sir
    
    private int playerId;


    public Player( int playerId,string name,int JerseyNumber, string Position,int age,
    string nationality,decimal salary)
    {
         PlayerId =playerId; 
         Name = name;
         jerseyNumber =JerseyNumber;
         position = Position;
         Age = age;
         Nationality = nationality;
         Salary = salary;
    }

    //property
    public int PlayerId
    {
        get {return this.playerId ;}
        set{this.playerId= value;}
    }
    
    //Auto property

    public string Name{get; set;}
    public int jerseyNumber{get;set;}
    public string position{get;set;}
    public int Age {get ;set;}
    public String Nationality{get;set;}
    public decimal Salary{get;set;}


}