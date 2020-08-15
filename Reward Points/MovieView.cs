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
        private DateTime _dateView; // when they viewed the movie and got rewarded points 
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
        public MovieView(string movie, DateTime date, bool three_dimentional, bool delux)
        {
            _movieName = movie;
            _dateView = date;
            _threeDeeMovie = three_dimentional;
            _deluxSeat = delux;
            // Points calculations (IF see movie = 1)
            _rewardPoints = 1;
            if (_threeDeeMovie == true)
            {
                _rewardPoints += 2;
            }
            if (_deluxSeat == true)
            {
                _rewardPoints += 4;
            }

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
        /// <summary>
        /// Checking whether the reward points have expired or not
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public bool Expired(DateTime today)
        {
            //DateTime dateTime = new DateTime(2008, 3, 1);  
            if (today.Year > _dateView.Year + 1)
            {
                return true;
            }
            else if (today.Year > _dateView.Year)
            {
                if (today.Month > _dateView.Month)
                {
                    return true;

                }
                else
                {
                    if (today.Day > _dateView.Day)
                    {
                        return true;

                    }
                    else
                    {
                        return false;

                    }
                }
            }
            else
            {
                return false;
            }
        }

        //public override string ToString()
        //{
        //    return Points.ToString().PadRight(10) + Expired().ToString().PadRight(5);
        //}
    }
}
