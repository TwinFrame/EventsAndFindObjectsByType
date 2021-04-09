using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class FreeWayChecker : MonoBehaviour
{
	[SerializeField] private ContactFilter2D _colliderBlock;

	private Rigidbody2D _rigidbody2D;
	private readonly RaycastHit2D[] _results = new RaycastHit2D[1];
	private bool _isFreeWay;

	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
	private void FixedUpdate()
	{
		var collisionCount = _rigidbody2D.Cast(transform.right, _colliderBlock, _results, 10);

		if (collisionCount == 0)
			_isFreeWay = true;
		else
		{
			_isFreeWay = false;
		}
	}

	public bool GetIsFreeWay()
	{
		return _isFreeWay;
	}
}
