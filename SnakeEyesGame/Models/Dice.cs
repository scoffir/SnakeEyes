using System;

namespace SnakeEyesGame.Models
{

    public class Dice
    {
        #region Fields
        private static Random _random = new Random();
        #endregion

        #region Properties
        public int Pips { get; private set; } 
        #endregion

        #region Constructor
        public Dice()
        {
            Pips = 6;
        }
        #endregion

        #region Methods
        public void Roll()
        {
            Pips = _random.Next(1, 7);
        }
        #endregion
    }
}