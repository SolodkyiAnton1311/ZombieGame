using System.Collections;
using UnityEngine;
public class ZombieHealth : ObjectHealth
{
    private Collider _collider;
    void Start()
    {
        baseObject = GetComponent<Zombie>();
        currentHealth = baseObject.movableObject.maxHealth;
        _collider = GetComponent<Collider>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(other.gameObject.GetComponent<Bullet>().Damage);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            TakeDamage(other.GetComponentInParent<PlayerMelee>().Damage);
            Debug.Log(other.GetComponentInParent<PlayerMelee>().Damage);
        }
    }

   private void TakeDamage(float damage)
    {
        currentHealth -= damage;
        baseObject.Animator.SetTrigger("TakeDamage");
        if (currentHealth <= 0)
        {
            _collider.enabled = false;
            GameManager.Instance.ZombieDie();
            StartCoroutine(Die());
            baseObject.Animator.SetBool("isDie",true);
        }
        
    }

    IEnumerator Die()
    {
        var anim = baseObject.Animator.GetCurrentAnimatorStateInfo(0);
        yield return new WaitForSeconds(anim.length);
        Destroy(gameObject);
    }
   
}