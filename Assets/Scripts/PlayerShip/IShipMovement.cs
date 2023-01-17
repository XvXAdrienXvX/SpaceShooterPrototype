namespace Assets.Scripts.PlayerShip
{
    public interface IShipMovement
    {
        void Turn(MovementType movement);
        void ApplyThrust();
    }
}
