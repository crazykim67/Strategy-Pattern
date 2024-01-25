using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyWeapon
{
    private IWeapon weapon;

    public void SetWeapon(IWeapon _weapon) => this.weapon = _weapon;

    public void Shoot() => weapon.Shoot();
}
