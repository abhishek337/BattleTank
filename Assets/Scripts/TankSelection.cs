using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public SpawnTank spawnTank;

    public void BlueTankSelected()
    {
        Debug.Log("Blue Tank");
        spawnTank.CreateModel(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        Debug.Log("Red Tank");
        spawnTank.CreateModel(TankType.RedTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        Debug.Log("Green Tank");
        spawnTank.CreateModel(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }
}
