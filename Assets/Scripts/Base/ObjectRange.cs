using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectRange : ObjectAttack,IRange
{
    [SerializeField] protected Bullet _bulletPrefab;
    [SerializeField] protected Transform _bulletSpawn;

    public void Shoot()
    {
      
    }
}
