using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private float _force = 5.0f;
    private int _secondJump;

    public void MakeJump()
    {
        if (Player.is_ground)
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
            _secondJump = 0;
        }
        else if (_secondJump == 0)
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
            _secondJump = 1;
        }
    }
}