using UnityEngine;

public class TankModel
{
    public float movementSpeed;

    public float rotationSpeed;

    public TankType tankType;

    public Material color;

    private TankController tankController;

    public TankModel(float _movement, float _rotation, TankType _tank, Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = _tank;
        color = _color;
    }

    public void setTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
