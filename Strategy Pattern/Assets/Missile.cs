using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : IWeapon
{
    public Missile() => Debug.Log("미사일로 변경");

    public void Shoot() => Debug.Log("미사일");
}
