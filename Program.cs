VideoLibary videoLibary = new VideoLibary();
videoLibary.AddGuest(new Guest("thingie", "Nothing street 2."));
videoLibary.AddGuest(new Guest("thingie2", "Nothing street 3."));
videoLibary.AddGuest(new Guest("thingie3", "Nothing street 4."));
videoLibary.AddVideo(new Video("Star Wars 2 trillionth", "idk"));
videoLibary.AddVideo(new Video("Star Wars 3 trillionth", "idk"));
videoLibary.AddVideo(new Video("Star Wars 4 trillionth", "idk"));
for (int i = 0; i < videoLibary.Guests.Count; i++)
{
    System.Console.WriteLine(videoLibary.Guests[i].GetName());
}
for (int i = 0; i < videoLibary.Videos.Count; i++)
{
    System.Console.WriteLine(videoLibary.Videos[i].GetTitle() + " | " + videoLibary.Videos[i].IsItRented());
}
videoLibary.Borrow(videoLibary.Guests[0], videoLibary.Videos[1]);
System.Console.WriteLine("------------------Borrow");
for (int i = 0; i < videoLibary.Videos.Count; i++)
{
    System.Console.WriteLine(videoLibary.Videos[i].GetTitle() + " | " + videoLibary.Videos[i].IsItRented());
}
videoLibary.ReturnVideo(videoLibary.Guests[0]);
System.Console.WriteLine("------------------Return");
for (int i = 0; i < videoLibary.Videos.Count; i++)
{
    System.Console.WriteLine(videoLibary.Videos[i].GetTitle() + " | " + videoLibary.Videos[i].IsItRented());
}
System.Console.WriteLine("------------------");
System.Console.WriteLine(videoLibary.GetMostOftenBorrowed().GetTitle() + " | " + videoLibary.GetMostOftenBorrowed().GetAmountOfRents());