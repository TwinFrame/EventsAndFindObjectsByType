using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectPoints : MonoBehaviour
{
	private CheckedPoint[] _checkedPoints;

	private void OnEnable()
	{
		Debug.Log("Меня вызвали OnEnable");

		_checkedPoints = gameObject.GetComponentsInChildren<CheckedPoint>();

		foreach (CheckedPoint point in _checkedPoints)
		{
			point.Reached += CollectedAllPoints;
		}
	}

	private void OnDisable()
	{
		Debug.Log("Меня вызвали OnDisable");

		foreach (CheckedPoint point in _checkedPoints)
		{
			point.Reached -= CollectedAllPoints;
		}
	}

	private void CollectedAllPoints()
	{
		Debug.Log("Меня вызвали CollectedAllPoints");

		foreach (var point in _checkedPoints)
			if (point.IsReached == false)
				return;

		Debug.Log("Все контрольные точки пройдены.");
	}
}
