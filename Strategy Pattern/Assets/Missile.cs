using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : IWeapon
{
    public Missile() => Debug.Log("�̻��Ϸ� ����");

    public void Shoot() => Debug.Log("�̻���");
}
