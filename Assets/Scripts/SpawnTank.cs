using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    public TankView  tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateModel();
    }

    void CreateModel()
    {
        TankModel tankModel = new TankModel(20,30);

        TankController tankController = new TankController(tankView, tankModel);


    }
}
