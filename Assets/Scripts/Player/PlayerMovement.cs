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
        _rb.velocity = new Vector3(_movementJoyStick.Horizontal*_speed, 0, _movementJoyStick.Vertical*_speed);
        if (_movementJoyStick.Horizontal != 0 || _movementJoyStick.Vertical != 0)
        {
            baseObject.Animator.SetBool("isRun", true);
        }
        else
            baseObject.Animator.SetBool("isRun", false);
    }
    
    
}