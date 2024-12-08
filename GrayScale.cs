using System;

namespace VideoLibaryProgram
{
    internal class GrayScale : Video
    {
        public GrayScale(string title = "", string director = "", DateTime releaseDate = new DateTime(), double price = 6.99, int amountOfRents = 0, bool isItRented = false) : base(title, director, releaseDate, price, amountOfRents, isItRented)
        {
            
        }
        public override Video Copy()
        {
            throw new InvalidOperationException("A rendőrség hamarosan megtalál téged");
        }
    }
}
