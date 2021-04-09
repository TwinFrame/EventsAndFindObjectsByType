using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finished : MonoBehaviour
{
	[SerializeField] private UnityEvent _finish;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.TryGetComponent<Player>(out Player player))
		{
			Debug.Log("Finished");
			_finish.Invoke();
		}
	}
}
