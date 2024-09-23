using UnityEngine;

public class Zombie : BaseObject
{
    [SerializeField] private Transform target;
    private bool isAttacking;
    public bool IsAttacking
    {
        get => isAttacking;
        set => isAttacking = value;
    }

    public Transform Target
    {
        get => target;
        set => target = value;
    }
}