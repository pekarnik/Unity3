using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
	public abstract class BaseObjectScene : MonoBehaviour
	{
		private int _layer;
		private Color _color;
		private bool _isVisible;
		[HideInInspector] public Rigidbody Rigidbody;
		protected virtual void Awake()
		{
			if (GetComponent<Rigidbody>())
			{
				Rigidbody = GetComponent<Rigidbody>();
			}
		}

		public string Name
		{
			get => gameObject.name;
			set => gameObject.name = value;
		}
		public int Layer
		{
			get => _layer;
			set
			{
				_layer = value;
				AskLayer(transform, _layer);
			}
		}

		public Color Color
		{
			get => _color;
			set
			{
				_color = value;
				AskColor(transform, _color);
			}
		}
		public bool IsVisible
		{
			get => _isVisible;
			set
			{
				_isVisible = value;
				var tempRenderer = GetComponent<Renderer>();
				if (tempRenderer)
				{
					tempRenderer.enabled = _isVisible;
				}
				if (transform.childCount <= 0) return;
				foreach (Transform d in transform)
				{
					tempRenderer = d.gameObject.GetComponent<Renderer>();
					if (tempRenderer)
						tempRenderer.enabled = _isVisible;
				}
			}
		}

		private void AskLayer(Transform obj, int layer)
		{
			obj.gameObject.layer = layer;
			if (obj.childCount <= 0) return;

			foreach (Transform child in obj)
			{
				AskLayer(child, layer);
			}
		}
		private void AskColor(Transform obj, Color color)
		{
			foreach (var curMaterial in obj.GetComponent<Renderer>().materials)
			{
				curMaterial.color = color;
			}
			if (obj.childCount <= 0) return;
			foreach (Transform d in obj)
			{
				AskColor(d, color);
			}
		}
		public bool IsRigidbody() => Rigidbody;

		public void DisableRigidBody()
		{
			if (!IsRigidbody()) return;

			var rigidbodies = GetComponentsInChildren<Rigidbody>();
			foreach (var rb in rigidbodies)
			{
				rb.isKinematic = true;
			}
		}

		public void EnableRigidbody(float force)
		{
			EnableRigidbody();

			Rigidbody.AddForce(transform.forward * force);
		}

		public void EnableRigidbody()
		{
			if (!IsRigidbody()) return;
			var rigidbodies = GetComponentsInChildren<Rigidbody>();
			foreach(var rb in rigidbodies)
			{
				rb.isKinematic = false;
			}
			
		}

		public void ConstraintsRigidbody(RigidbodyConstraints rigidbodyConstraints)
		{
			var rigidbodies = GetComponentsInChildren<Rigidbody>();
			foreach(var rb in rigidbodies)
			{
				rb.constraints = rigidbodyConstraints;
			}
		}

		public void SetActive(bool value)
		{
			IsVisible = value;

			var tempCollider = GetComponent<Collider>();
			if(tempCollider)
			{
				tempCollider.enabled = value;
			}
		}

	}
}
