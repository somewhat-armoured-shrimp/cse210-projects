using System;

class Program
{
    static void Main(string[] args)
    {
        // list o vidyos
        List<Video> videos = new List<Video>();

        // constructors are nice i think
        Video video1 = new Video("10 Youtubers vs 1,000,000 babies", "MrBeast", 10000);
        
        video1.Add(new Comment("hateful dude", "dude i HATE this video"));
        video1.Add(new Comment("regular dude", "@hateful dude Don't say that. That's unkind."));
        video1.Add(new Comment("Katya", "Join my ExclusivelyAirVents <33"));
        video1.Add(new Comment("Bakugou", "i love your vidoes mr beast :)"));
        videos.Add(video1);

        Video video2 = new Video("hi guys", "michael7362581", 172);
        video2.Add(new Comment("Bob Walters", "cool video"));
        video2.Add(new Comment("michael7362581", "thanks man"));
        video2.Add(new Comment("Anime Hannibal Lecter", "why did the algorithm take me here??"));
        videos.Add(video2);

        Video video3 = new Video("Is Your Spouse Cheating? How to Tell.", "Catie Adam Scott, PhD", 2826);
        video3.Add(new Comment("dave", "my wife sent this to me?"));
        video3.Add(new Comment("LynxxGames", "@dave lmao rip"));
        video3.Add(new Comment("dave", "i just got home from work and every trace of her is gone."));
        video3.Add(new Comment("VinDictive", "The algorithm knows me too well..."));
        videos.Add(video3);

        Video video4 = new Video("The Most Tragic Japanese Indie FPS Horror Mystery Slice of Life Game You've Never Played", "BunnyManics", 28643);
        video4.Add(new Comment("jerry holmes", "what"));
        video4.Add(new Comment("stickied-keys", "i legit cried when yumi died even though she was the villain. she was basically tortured when she was turned into a sentient pile of sewn-together stuffed animals by her father. Broke my heart."));
        video4.Add(new Comment("bombomkitten", "Me before watching: 'it can't be that tragic, the title is exxagerating lol' Me after watching: *stares deadly off in space*"));
        video4.Add(new Comment("CryJinks", "@stickied-keys her screams were haunting :("));

        Console.WriteLine(video1.GetDisplayText());
        Console.WriteLine(video2.GetDisplayText());
        Console.WriteLine(video3.GetDisplayText());
        Console.WriteLine(video4.GetDisplayText());
    }
}