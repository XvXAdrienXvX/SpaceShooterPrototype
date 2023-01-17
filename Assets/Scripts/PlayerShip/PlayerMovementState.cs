using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.PlayerShip
{
    public enum MovementType
    {
        yaw,
        pitch,
        roll
    }

    public class PlayerMovementState : IShipMovement
    {
        public void ApplyThrust()
        {
            throw new NotImplementedException();
        }

        public void Turn(MovementType movement)
        {
            throw new NotImplementedException();
        }
    }
}
