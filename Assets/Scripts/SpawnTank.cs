using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    public GameObject TankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(TankPrefab, transform.position, Quaternion.identity);
    }
}