using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovenmetToPath : MonoBehaviour
{
	[SerializeField] private float _speed;

	private Transform[] _pathPoints;
	private int _currentPoint;


	private void Start()
	{
		_pathPoints = GameObject.FindGameObjectWithTag("ParentPatrulePoints").GetComponent<CollectPathPoints>().GetPathPoints();
	}

	private void Update()
	{
		Transform target = _pathPoints[_currentPoint];

		transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

		if (transform.position == target.position)
		{
			_currentPoint++;
		}

		if (_currentPoint >= _pathPoints.Length)
		{
			_currentPoint = 0;
		}

	}
}
