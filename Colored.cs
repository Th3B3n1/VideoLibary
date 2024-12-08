using System;

namespace VideoLibaryProgram
{
    internal class Colored : Video
    {
        public Colored(string title = "", string director = "", DateTime releaseDate = new DateTime(), double price = 3.99, int amountOfRents = 0, bool isItRented = false) : base(title, director, releaseDate, price, amountOfRents, isItRented)
        {

        }
    }
}
