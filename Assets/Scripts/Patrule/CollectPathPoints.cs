using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPathPoints : MonoBehaviour
{
	private Transform[] _pathPoints;

	private void Start()
	{
		_pathPoints = gameObject.GetComponentsInChildren<Transform>();

		foreach (var point in _pathPoints)
		{
			Debug.Log(point.name);
		}
	}

	public Transform[] GetPathPoints()
	{
		return _pathPoints;
	}
}
