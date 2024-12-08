internal class Video
{
    private string title;
    private string director;
    private System.DateTime releaseDate;
    private double price;
    private int amountOfRents;
    private bool isItRented;
    public Video(string title = "", string director = "", System.DateTime releaseDate = new System.DateTime(), double price = 0, int amountOfRents = 0, bool isItRented = false)
    {
        this.title = title;
        this.director = director;
        this.releaseDate = releaseDate;
        this.price = price;
        this.amountOfRents = amountOfRents;
        this.isItRented = isItRented;
    }
    public string GetTitle()
    {
        return this.title;
    }
    public string GetDirector()
    {
        return this.director;
    }
    public System.DateTime GetReleaseDate()
    {
        return this.releaseDate;
    }
    public double GetPrice()
    {
        return this.price;
    }
    public int GetAmountOfRents()
    {
        return this.amountOfRents;
    }
    public bool IsItRented()
    {
        return this.isItRented;
    }
    public void AddToAmountOfRents(int amount)
    {
        this.amountOfRents += amount;
    }
    public void SetRented(bool isItRented)
    {
        this.isItRented = isItRented;
    }
    public override string ToString()
    {
        return this.title + ", " + this.director + " által, " + "kiadási dátum: " + this.releaseDate.Year + " - " + this.amountOfRents + " alkalommal kölcsönözték.";
    }
    public override bool Equals(object? obj)
    {
        Video? video = obj as Video;
        if (this.title == video?.GetTitle())
        {
            return true;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return System.HashCode.Combine(this.GetTitle());
    }
    public virtual Video Copy()
    {
        return new Video(this.title, this.director, this.releaseDate, this.price, this.amountOfRents, this.isItRented);
    }
}