using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]

public class FreeWayCastChecker : MonoBehaviour
{
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private UnityEvent _allowWay;
    [SerializeField] private UnityEvent _denyWay;

    private Rigidbody2D _rigidbody2D;

    private RaycastHit2D[] _hits = new RaycastHit2D[1];
    private int _countHit;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.right * 7, Color.yellow);

        _countHit = _rigidbody2D.Cast(transform.right, _filter, _hits);

        if (_countHit == 0)
        {
            _allowWay.Invoke();
        }
        else
        {
            //Debug.Log("попался" + _hits[0].collider.name);
            _denyWay.Invoke();
        }
    }
}
