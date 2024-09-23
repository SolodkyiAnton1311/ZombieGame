using System.Collections;
using UnityEngine;

public class PlayerMelee : ObjectAttack 
{
    [SerializeField] private GameObject box;
    private float meleeAtackDelay;
   

    public int Damage
    {
        get => damage;
    }
    private void Start()
    {
        damage = movableObject.MovableObject.damage;
        meleeAtackDelay = movableObject.MovableObject.attackDelay;
        attackRange = movableObject.MovableObject.attackRange;
    }
    
    public void Attack()
    {
        StartCoroutine(AttackCorutine());
    }
    IEnumerator AttackCorutine()
    {
        box.gameObject.SetActive(true);
        yield return new WaitForSeconds(meleeAtackDelay);
        box.gameObject.SetActive(false);
    }
}
