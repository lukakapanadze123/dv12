using System;
using System.Collections.Generic;
using System.Text;

namespace dv12
{
    internal class Movie : IComparable<Movie>
    {
        public Movie(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public int Year { get; set; }

        public int CompareTo(Movie? other)
        {
            return this.Year.CompareTo(other.Year);
        }

        public override bool Equals(object? obj)
        {
            return obj is Movie movie
                && this.Name == movie.Name
                && this.Year == movie.Year;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
