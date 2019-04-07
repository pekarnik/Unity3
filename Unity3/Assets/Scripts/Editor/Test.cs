using System;
using UnityEngine;
namespace FPS.Editor
{
	public class Test:MonoBehaviour
	{
		[SerializeField] private GameObject _prefab;

		public void InstantiateObj(Vector3 pos)
		{
			Instantiate(_prefab, pos, Quaternion.identity);
		}
	}
}
