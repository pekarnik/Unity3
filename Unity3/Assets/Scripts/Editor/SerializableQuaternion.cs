using System;
using UnityEngine;

namespace FPS.Editor
{
	[Serializable]
	public struct SerializableQuaternion
	{
		public float X;
		public float Y;
		public float Z;
		public float W;

		public SerializableQuaternion(float x,float y,float z,float w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}
		public static implicit operator Quaternion(SerializableQuaternion value)
		{
			return new Quaternion(value.X, value.Y, value.Z, value.W);
		}
		public static implicit operator SerializableQuaternion(Quaternion value)
		{
			return new SerializableQuaternion(value.x, value.y, value.z, value.w);
		}
	}
}