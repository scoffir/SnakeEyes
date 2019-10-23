using Newtonsoft.Json;
using System;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes
    {
        #region Fields
        private readonly Dice _dice1;
        private readonly Dice _dice2;
        #endregion

        #region Properties

        public int Total { get; private set; }

        public int Eye1 => _dice1.Pips;

        public int Eye2 => _dice2.Pips;
        #endregion

        #region Constructor
        public SnakeEyes()
        {
            _dice1 = new Dice();
            _dice2 = new Dice();
            Total = 0;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Rolls the dices. Calculates the total.
        /// </summary>
        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();
            if (Eye1 == 1 && Eye2 == 1)
                Total = 0;
            else
                Total += Eye1 + Eye2;
        }
        #endregion
    }
}