using System;

namespace SnakeEyesGame.Models
{

    public class SnakeEyes
    {
        #region Fields
        private readonly Dice _eye1;
        private readonly Dice _eye2;
        #endregion

        #region Properties

        public int Total { get; private set; }

        public int Eye1 => _eye1.Pips;

        public int Eye2 => _eye2.Pips;
        #endregion

        #region Constructor
        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Rolls the dices. Calculates the total.
        /// </summary>
        public void Play()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}