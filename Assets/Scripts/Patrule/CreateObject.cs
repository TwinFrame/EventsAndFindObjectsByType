using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
	[SerializeField] private GameObject _object;

	private Vector3 _startPosition;


	private void Start()
	{
		_startPosition = GameObject.FindGameObjectWithTag("ParentPatrulePoints").GetComponent<CollectPathPoints>().GetPathPoints()[0].position;
		Instantiate(_object, _startPosition, Quaternion.identity);
	}

}
