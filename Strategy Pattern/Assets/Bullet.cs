using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : IWeapon
{
    public Bullet() => Debug.Log("������ ����");

    public void Shoot() => Debug.Log("�Ѿ�");
}
