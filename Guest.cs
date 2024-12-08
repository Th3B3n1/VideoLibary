internal class Guest
{
    private string name;
    private string address;
    private Video video = new();
    public Guest(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetAddress()
    {
        return this.address;
    }
    public Video GetVideo()
    {
        return this.video;
    }
    public void SetVideo(Video video)
    {
        this.video = video;
    }
    public void RemoveAnyVideo()
    {
        this.video = new Video();
    }
    public override string ToString()
    {
        return this.name + " jelenleg " + (this.video.GetTitle() != "" ? "a " + this.video.GetTitle() + "-t kölcsönzi." : "nem kölcsönöz semmit.");
    }
    public Video Steal()
    {
        if (!this.video.Equals(new Video()))
        {
            return new Video(this.video.GetTitle(), this.video.GetDirector(), this.video.GetReleaseDate(), this.video.GetPrice(), this.video.GetAmountOfRents(), this.video.IsItRented());
        }
        else
        {
            System.Console.WriteLine("Nincs elérhető videó lopásra");
            return new Video();
        }
    }
}