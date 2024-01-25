using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : IWeapon
{
    public Bullet() => Debug.Log("ÃÑÀ¸·Î º¯°æ");

    public void Shoot() => Debug.Log("ÃÑ¾Ë");
}
