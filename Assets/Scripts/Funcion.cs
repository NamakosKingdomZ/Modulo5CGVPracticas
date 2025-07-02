using UnityEngine;
using System;

public class Funcion : MonoBehaviour
{
	#region Properties
	#endregion

	#region Fields
	[SerializeField]
	private float force = 10f;
	[SerializeField]
	private float radius = 5f;

	#endregion

	#region Unity Callbacks
	
    void FixedUpdate()
    {
		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

		foreach (Collider col in colliders)
		{
			Rigidbody rb = col.attachedRigidbody;

			if (rb != null && rb != GetComponent<Rigidbody>())
			{
				Vector3 dir = (transform.position - col.transform.position).normalized;

				if (col.CompareTag("Metal"))
				{
					// Atraer
					rb.AddForce(dir * force);
				}
				else if (col.CompareTag("Normal"))
				{
					// Repeler
					rb.AddForce(-dir * force);
				}
			}
		}
	}
}
	#endregion

	#region Public Methods
	#endregion


	#region Private Methods
	
	#endregion



