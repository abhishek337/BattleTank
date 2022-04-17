using UnityEngine;

public class TankController
{
    private TankView tankView;

    private TankModel tankModel;

    private Rigidbody Rb;

    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankView = GameObject.Instantiate<TankView>(_tankView);
        tankModel = _tankModel;

        Rb = tankView.GetRigidbody();

        tankModel.setTankController(this);
        tankView.setTankController(this);

    }

    public void Move(float movement, float movespeed)
    {
        Rb.velocity = tankView.transform.forward * movement * movespeed;
    }

    public void Rotate(float turn, float turnSpeed)
    {
        Vector3 vector = new Vector3(0f, turn * turnSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        Rb.MoveRotation(Rb.rotation * deltaRotation);
    }

    public TankModel getTankModel()
    {
        return tankModel;
    }
}