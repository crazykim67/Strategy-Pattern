using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : IWeapon
{
    public Arrow() => Debug.Log("ȭ��� ����");

    public void Shoot() => Debug.Log("ȭ��");
}
