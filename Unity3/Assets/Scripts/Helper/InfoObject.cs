using UnityEngine;

namespace FPS
{
	public struct InfoObject
	{
		private ObjectType _type;

		private float _distance;

		public InfoObject(ObjectType type, float distance=0)
		{
			_type = type;
			_distance = distance;
		}

		public ObjectType Type => _type;
		public float Distance => _distance;
	}
}