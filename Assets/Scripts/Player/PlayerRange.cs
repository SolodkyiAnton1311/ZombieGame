using System;
using UnityEngine;

public class PlayerRange : ObjectRange
{
    [SerializeField] private FixedJoystick _movementJoyStick;
    private BaseObject _baseObject;

    private void Start()
    {
        _baseObject = GetComponent<BaseObject>();
        attackDelay = _baseObject.MovableObject.attackDelay;
        nextAttackTime = 0;
    }

    void FixedUpdate()
    {
        if (_movementJoyStick.Horizontal != 0 || _movementJoyStick.Vertical != 0)
        {
            transform.rotation =
                Quaternion.LookRotation(new Vector3(_movementJoyStick.Horizontal, 0, _movementJoyStick.Vertical));

            if (Time.time >= nextAttackTime)
            {
                Shoot();
                nextAttackTime = Time.time + attackDelay;
            }
        }
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(_bulletPrefab, _bulletSpawn.position, transform.rotation);
        bullet.Init(_bulletSpawn.position, transform.forward, _baseObject.MovableObject.attackRange);
    }
}