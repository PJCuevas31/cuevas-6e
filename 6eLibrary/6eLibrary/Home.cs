using _6eLibrary;
namespace _UserRate;
using _UserRate;
class Home {
    public void HomeScreen()
    {
        Console.WriteLine("Enter the Anime of your choice: ");
        Console.WriteLine("One Piece");
        Console.WriteLine("Chainsaw Man");
        Console.WriteLine("Overlord");
        Console.WriteLine("Hell's Paradise");
        Console.WriteLine("Shangri-La Frontier");
        Console.WriteLine("Mashle: Magic & Muscles");
        Console.WriteLine("The Eminence in Shadow");

        string AnimeName=Console.ReadLine();
        Console.WriteLine("\n------------------");

        Description description = new Description();
        Rating rating = new Rating();   
        Genre genre= new Genre();
        ReleaseStatus stat= new ReleaseStatus();
        userate anirate = new userate();

        if (AnimeName == "One Piece")
        {
            description.opdesc();
            rating.oprate();
            genre.opgen();
            stat.oprel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if(AnimeName =="Chainsaw Man")
        {
            description.csmdesc();  
            rating.csmrate();
            genre.csmgen();
            stat.csmrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if (AnimeName == "Overlord")
        {
            description.ovldesc();
            rating.ovlrate(); 
            genre.ovlgen();
            stat.ovlrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if(AnimeName == "Hell's Paradise")
        {
            description.jgkdesc(); 
            rating.jgkrate();
            genre.jgkgen();
            stat.jgkrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if (AnimeName == "Shangri-La Frontier")
        {
            description.sfldesc();
            rating.sflrate();
            genre.sflgen();
            stat.sflrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if (AnimeName == "Mashle: Magic & Muscles")
        {
            description.mashdesc();
            rating.mashrate();
            genre.mashgen();
            stat.mashrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else if (AnimeName == "The Eminence in Shadow")
        {
            description.teisdesc();
            rating.teisrate();
            genre.teisgen();
            stat.teisrel();
            Console.WriteLine("\n------------------");
            anirate.animusse();
        }
        else
        {
            Console.WriteLine("The Anime you entered is not in our directory");
        }
    }
        }