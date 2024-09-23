using UnityEngine;

public abstract class ObjectMovement : MonoBehaviour
{
    protected Rigidbody _rb;
    protected float _speed;
   [SerializeField] protected BaseObject baseObject;

    private void Start()
    {
        baseObject = GetComponent<BaseObject>();
        _rb = GetComponent<Rigidbody>();
        _speed = baseObject.movableObject.speed;
    }

    private void Move() {}
}
