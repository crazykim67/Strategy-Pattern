using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : IWeapon
{
    public Arrow() => Debug.Log("화살로 변경");

    public void Shoot() => Debug.Log("화살");
}
