using UnityEngine;
public class ZombieAttack : ObjectAttack
{
    private Transform target;
    private Zombie _zombie;
    private Animator animator;

    private void Start()
    {
        _zombie = GetComponent<Zombie>();
        target = _zombie.Target;
        animator = _zombie.Animator;
        attackRange = _zombie.movableObject.attackRange;
        attackDelay = _zombie.movableObject.attackDelay;
    }
    private void FixedUpdate()
    {
        float distanceToPlayer = Vector3.Distance(target.position, transform.position);
        if (distanceToPlayer <= attackRange)
        {
            if (Time.time >= nextAttackTime)
            {
                Attack();
                nextAttackTime = Time.time + attackDelay;
            }
        }
        else
        {
            _zombie.IsAttacking = false;
            animator.SetBool("isAttack", false);
        }
    }

    private void Attack()
    {
        _zombie.IsAttacking = true;
        animator.SetBool("isAttack", true);
        target.GetComponent<PlayerHealth>().TakeDamage(_zombie.movableObject.damage);
    }
}