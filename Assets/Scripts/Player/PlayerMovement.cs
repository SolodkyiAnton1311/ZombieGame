using UnityEngine;

public class PlayerMovement : ObjectMovement
{
    [SerializeField] private FixedJoystick _movementJoyStick;
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (_movementJoyStick.Horizontal != 0 || _movementJoyStick.Vertical != 0)
        {
            baseObject.Animator.SetBool("isRun", true);
        }
        else
            baseObject.Animator.SetBool("isRun", false);
    }
    
    
}