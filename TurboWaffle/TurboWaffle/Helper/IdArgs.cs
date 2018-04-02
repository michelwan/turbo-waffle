using System;

namespace TurboWaffle.Helper
{
    public class IdArgs : EventArgs
    {
        #region Properties
        public int Id { get; set; }
        #endregion Properties

        public IdArgs(int id)
        {
            Id = id;
        }
    }
}
