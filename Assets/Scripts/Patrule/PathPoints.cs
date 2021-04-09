using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPoints : MonoBehaviour
{
	private GameObject[] _pathPoints;

	private void Start()
	{
		_pathPoints = GameObject.FindGameObjectsWithTag("PatrulePoint");

		foreach (var point in _pathPoints)
		{
			Debug.Log(point.name);
		}
	}

	public GameObject[] GetPathPoints()
	{
		return _pathPoints;
	}
}
