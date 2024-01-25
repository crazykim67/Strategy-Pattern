using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyUse : MonoBehaviour
{
    MyWeapon myweapon;

    private void Start()
    {
        myweapon = new MyWeapon();
        myweapon.SetWeapon(new Bullet());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeBullet();
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeArrow();
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeMissile();
        else if (Input.GetMouseButtonDown(0))
            Fire();
    }

    public void ChangeBullet() => myweapon.SetWeapon(new Bullet());

    public void ChangeMissile() => myweapon.SetWeapon(new Missile());

    public void ChangeArrow() => myweapon.SetWeapon(new Arrow());

    public void Fire() => myweapon.Shoot();
}
