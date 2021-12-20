using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{

    public GameObject primary;

    Weapon primaryWeapon;
    GameObject instWeapon;

    // Start is called before the first frame update
    void Start()
    {
        instWeapon = Instantiate(primary);
        primaryWeapon = instWeapon.GetComponent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        instWeapon.transform.position = transform.position;
    }
}
