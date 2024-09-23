using System.Collections;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] public float damage; 
    public float Damage
    {
        get => damage;
      
    }
    public void Init(Vector3 startPosition, Vector3 direction,float _destroyDistance)
    {
        if (_rb == null)
            _rb = GetComponent<Rigidbody>();

        transform.position = startPosition;
        _rb.velocity = direction * _speed;

        float lifeTime = _destroyDistance / _speed;
        StartCoroutine(AutoDestroy(lifeTime));
    }

    private IEnumerator AutoDestroy(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}