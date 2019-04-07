using System;

namespace FPS.Editor
{
	[Serializable]
	public struct SerializableGameObject
	{
		public string Name;
		public SerializableVector3 Pos;
		public SerializableQuaternion Rot;
		public SerializableVector3 Scale;
	}
}
