using UnityEngine;
public abstract class ObjectHealth : MonoBehaviour
{
   [SerializeField] protected BaseObject baseObject;
   protected float currentHealth;
   private void Start()
   {
      baseObject = GetComponent<BaseObject>();
   }
   public void TakeDamage()
   {
      
   }
}
