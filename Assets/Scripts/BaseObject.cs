using UnityEngine;

public class BaseObject : MonoBehaviour
{
 
    
    public MovableObject movableObject;
    [SerializeField] private Animator animator;

   
    public Animator Animator => animator;
    public MovableObject MovableObject => movableObject;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
}
