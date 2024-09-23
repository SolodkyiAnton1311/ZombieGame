using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : ObjectMovement
{
    private bool isAttack;
    private Transform target;
    private Animator animator;
    private Zombie _zombie;
    private void Start()
    {
        _zombie = GetComponent<Zombie>();
        target = _zombie.Target;
        animator = _zombie.Animator;
        _speed = _zombie.movableObject.speed;
        isAttack = false;
    }

    private void FixedUpdate()
    {
        if (!_zombie.IsAttacking)
        {
            Move();
        }
       
    }

    private void Move()
    {
        animator.SetBool("isRun", true);
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * (_speed * Time.deltaTime);
        transform.LookAt(target);
    }
}