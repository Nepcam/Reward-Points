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
        // store how many points were earned from the viewing
        // use the DateTime class to store the date

        // Fields that will store data 
        private string _movieName;
        private int _dateView;
        private bool _threeDeeMovie;
        private bool _deluxSeat;

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
        
        /// <summary>
        /// This property gets and sets the name of the movie
        /// </summary>
        public string Name
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        /// <summary>
        /// This property gets the date of the movie viewing
        /// </summary>
        public int Date
        {
            get { return _dateView; }
        }

        /// <summary>
        /// This property gets the info whether the client saw a 3D movies or not
        /// </summary>
        public bool ThreeD
        {
            get { return _threeDeeMovie; }
        }

        /// <summary>
        /// This property gets the info whether the client was seated in a delux section or not
        /// </summary>
        public bool Delux
        {
            get { return _deluxSeat; }
        }
        
        // return the value of the points earned from this viewing
        /// <summary>
        /// 
        /// </summary>
        public void int Points()
        {
            // viewing = 1
            // 3D viewing = 1 + 2
            // 3D & delux = (1 + 2) + 4
            get { }
        }
    }
}
