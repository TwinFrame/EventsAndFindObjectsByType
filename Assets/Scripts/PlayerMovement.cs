using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _speed;

	private FreeWayChecker _freeWayChecker;

	private void Awake()
	{
		_freeWayChecker = gameObject.GetComponent<FreeWayChecker>();
	}

	private void Update()
	{
		if (_freeWayChecker.GetIsFreeWay())
		{
			transform.Translate(_speed * Time.deltaTime, 0, 0);
		}
	}
}
