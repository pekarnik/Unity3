using System;
using UnityEngine;

namespace FPS.Editor
{
	[Serializable]
	public struct SerializableVector3
	{
		public float X;
		public float Y;
		public float Z;

		public SerializableVector3(float x, float y, float z)
		{
			X = x;
			Y = x;
			Z = z;
		}
		public static implicit operator Vector3(SerializableVector3 value)
		{
			return new Vector3(value.X, value.Y, value.Z);
		}
		public static implicit operator SerializableVector3(Vector3 value)
		{
			return new SerializableVector3(value.x, value.y, value.z);
		}
	}
}