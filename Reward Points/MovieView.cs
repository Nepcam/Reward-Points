using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reward_Points
{
    class MovieView
    {
        // class to store a movie viewing
        // calculate how many points a person has
        // store movie name
        // store when they viewed the movie
        // store how many points were earned from the viewing. viewing = 1; 3D viewing = 1 + 2; 3D & delux = (1 + 2) + 4
        // use the DateTime class to store the date

        // Fields that will store data 
        private string _movieName;
        private int _dateView; // when they viewed the movie
        DateTime dat1 = new DateTime(); 
        private bool _threeDeeMovie;
        private bool _deluxSeat;
        private int _rewardPoints;

        // Constructors ###################################################

        /// <summary>
        /// Initialise the fields to default values
        /// </summary>
        public MovieView()
        {
            _movieName = "";
            _dateView = 0;
            _threeDeeMovie = false;
            _deluxSeat = false;
            _rewardPoints = 0;
        }

        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="movie">The name of the movie</param>
        /// <param name="date">The date the client viewed the movie</param>
        /// <param name="three_dimentional">Did the client view a 3D movie?</param>
        /// <param name="delux">Was the client in the delux section</param>
        public MovieView(string movie, int date, bool three_dimentional, bool delux)
        {
            _movieName = movie;
            _dateView = date;
            _threeDeeMovie = three_dimentional;
            _deluxSeat = delux;
        }

        // Properties ###################################################

        // Points (read only) property - return points earned from viewing
        /// <summary>
        /// Gets the points from the reward system
        /// </summary>
        public int Points
        {
            get { return _rewardPoints; }
        }



        // Expired (method) - takes a DateTime object of a new date, and returns a bool

        public int Expired(int date)
        {
                       
        }
    }
}
