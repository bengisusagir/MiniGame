using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody),typeof(BoxCollider))]
public class JystckWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
        if(_joystick.Horizontal !=0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isWalking", true);
        }
        else
            _animator.SetBool("isWalking", false);
    }
}
