using UnityEngine;

public abstract class ObjectAttack : MonoBehaviour
{
    protected float attackDelay;
    protected float attackRange;
    protected float nextAttackTime = 0f;
    [SerializeField] protected BaseObject movableObject;
    protected int damage;
    private void Start()
    {
        
    }
}