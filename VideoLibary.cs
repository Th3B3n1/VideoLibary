internal class VideoLibary
{
    private System.Collections.Generic.List<Guest> guests = new System.Collections.Generic.List<Guest>();
    private System.Collections.Generic.List<Video> videos = new System.Collections.Generic.List<Video>();

    public System.Collections.Generic.List<Guest> Guests { get { return guests; } }
    public System.Collections.Generic.List<Video> Videos { get { return videos; } }
    public void AddGuest(Guest guest)
    {
        this.guests.Add(guest);
    }
    public void AddVideo(Video video)
    {
        this.videos.Add(video);
    }

    public void Borrow(Guest guest, Video video)
    {
        if (video.IsItRented())
        {
            throw new System.Exception("A videó nem elérhető");
        }
        else if (!(guest.GetVideo().Equals(new Video())))
        {
            throw new System.Exception("A vendég már kölcsönzött videót");
        }
        else if (guest.GetVideo().Equals(new Video()) || !(video.IsItRented()))
        {
            video.SetRented(true);
            guest.SetVideo(video);
        }
    }

    public void ReturnVideo(Guest guest)
    {
        guest.GetVideo().AddToAmountOfRents(1);
        guest.GetVideo().SetRented(false);
        guest.RemoveAnyVideo();
    }

    public Video GetMostOftenBorrowed()
    {
        Video mostOftenBorrowed = this.videos[0];
        for (int i = 0; i < this.videos.Count; i++)
        {
            if (this.videos[i].GetAmountOfRents() > mostOftenBorrowed.GetAmountOfRents())
            {
                mostOftenBorrowed = this.videos[i];
            }
        }
        return mostOftenBorrowed;
    }

    public override string ToString()
    {
        return "Az áruháznak jelenleg " + this.videos.Count + " videója van, és " + this.guests.Count + " regisztált vendége.";
    }
}
