using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCastMovement : MonoBehaviour
{
	[SerializeField] private float _speed;

	private IEnumerator _startMoving;

	public void Start()
	{
		_startMoving = MovePlayer();
	}

	public void StartMoving()
	{
		StartCoroutine(_startMoving);
	}

	 public void StopMoving()
	{
		StopAllCoroutines();
		if (_startMoving != null)
		{
			StopCoroutine(_startMoving);
		}
	}

	private IEnumerator MovePlayer()
	{
		while (true)
		{
			transform.Translate(_speed * Time.deltaTime, 0, 0);
			yield return null;
		}
	}
}
