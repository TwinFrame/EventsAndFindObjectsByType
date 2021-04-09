using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCheker : MonoBehaviour
{
    [SerializeField] private ContactFilter2D _enemy;

    private int _hit;
    private RaycastHit2D[] _hits = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        _hit = Physics2D.Raycast(transform.position, transform.right, _enemy, _hits);

        Debug.DrawRay(transform.position, transform.right * 7);

        if (_hit != 0)
        {
            Debug.Log(_hits[0].collider.gameObject);
            Destroy(_hits[0].collider.gameObject);
        }
    }

}
