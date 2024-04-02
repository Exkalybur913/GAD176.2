using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    [SerializeField] List <WeaponTypes> currentAmmunition;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform fireDirection;
    private int weaponIndex = 0;
    void Start()
    { 
        InvokeRepeating("Shoot", 1f, 1f);
    }

    private void Update()
    {
        for (int i = 1; i <= currentAmmunition.Count; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i) || Input.GetKeyDown(KeyCode.Keypad0 + i))
            {
                SwitchToWeapon(i - 1);
                break;
            }
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        var fireBullet = Instantiate(bullet,fireDirection.position, fireDirection.rotation);
        fireBullet.GetComponent<Bullet>().WeaponType = currentAmmunition[weaponIndex];
    }
    
    public void SwitchWeapons()
    {
        weaponIndex = (weaponIndex + 1) % currentAmmunition.Count;
    }

    public void SwitchToWeapon(int index)
    {
        if (index >= 0 && index < currentAmmunition.Count)
        {
            weaponIndex = index;
        }
    }
}
