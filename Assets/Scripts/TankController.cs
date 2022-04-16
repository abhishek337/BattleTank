using UnityEngine;

public class TankController
{
    private TankView tankView;

    private TankModel tankModel;

    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankView = _tankView;
        tankModel = _tankModel;

        _tankModel.setTankController(this);
        _tankView.setTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
