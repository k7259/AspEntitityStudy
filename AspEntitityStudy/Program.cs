// See https://aka.ms/new-console-template for more information
using DataAccessLayer;
using DataAccessLayer.Model;
using System.Runtime.Intrinsics.Arm;

//Console.WriteLine("Hello, World!");
var Db = new ApplicationDbContext();
IplTeam obj1= new IplTeam();
obj1.Name = "Mumbai indians";
IplTeam obj2= new IplTeam();
obj2.Name = "Delhi Capitals";



//Console.WriteLine("Adding New data");
//Db.IplTeams.Add(obj1);
//Db.SaveChanges();
//IplPlayer ip = new IplPlayer();
//ip.Name = "Rohit Sharma";
//ip.Team = obj1;
//Db.IplPlayers.Add(ip);
//Db.SaveChanges();
var db = obj1.Name.Where(d => obj1.Name == "Mumbai indians").First();





//Read 
//Console.WriteLine("Reading Data");
//var Team1 = Db.IplTeams.First();
//Console.WriteLine(Team1.Name);

// Searching For player name whose name start with R
//var myplayer = Db.IplPlayers.FirstOrDefault(x => x.Name.StartsWith("R"));
//var myplayer1=Db.IplTeams.Remove(obj2);


// 1. Write Code to Update Database
//2. Update Record in data base and Delete Record in data base





