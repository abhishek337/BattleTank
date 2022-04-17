using UnityEngine;

public class TankModel
{
    public float movementSpeed;
    public float rotationSpeed;

    private TankController tankController;

    public TankModel(float _movement, float _rotation)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
    }

    public void setTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
