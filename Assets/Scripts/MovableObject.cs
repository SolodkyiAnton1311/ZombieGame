using UnityEngine;
[CreateAssetMenu(fileName = "MovableObject", menuName = "MovableObject")]
public class MovableObject : ScriptableObject
{
   public int speed;
   public int maxHealth;
   public float attackDelay;
   public int attackRange;
   public int damage;
}
