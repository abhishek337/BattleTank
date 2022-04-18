using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    [System.Serializable]

    public class tank
    {
        public float movementSpeed;

        public float rotateSpeed;

        public TankType tankType;

        public Material color;
    }

    public List<tank> tankList;

    public TankView  tankView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateModel(TankType tankType)
    {
        if(tankType == TankType.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotateSpeed, tankList[2].tankType, tankList[2].color);

            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankType == TankType.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotateSpeed, tankList[0].tankType, tankList[0].color);

            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankType == TankType.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotateSpeed, tankList[1].tankType, tankList[1].color);

            TankController tankController = new TankController(tankView, tankModel);
        }

    }
}
