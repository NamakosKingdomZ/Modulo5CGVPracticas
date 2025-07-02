using UnityEngine;
using System;

public class ImanBall : MonoBehaviour
{
	#region Properties
	#endregion

	#region Fields
	[SerializeField]
	private Rigidbody imanRb;
	[SerializeField]
	private float speedMove = 10;
	#endregion

	#region Unity Callbacks

    
    void Update()
    {
		transform.Translate(Vector3.forward * Input.GetAxis("Horizontal") * Time.deltaTime * speedMove);
		transform.Translate(Vector3.left * Input.GetAxis("Vertical") * Time.deltaTime * speedMove);
        
    }
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
   
}
