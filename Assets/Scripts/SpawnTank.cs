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
        CreateModel();
    }

    void CreateModel()
    {
        TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotateSpeed, tankList[1].tankType, tankList[1].color);

        TankController tankController = new TankController(tankView, tankModel);

    }
}
