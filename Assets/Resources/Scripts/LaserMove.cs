using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
	#region Public Fields
	[SerializeField]
	private float speed = 3.0f;
	#endregion


	#region Protected Fields
	#endregion


	#region Private Fields
	#endregion


	#region MonoBehaviour Callbacks
	private void Start()
	{
		
	}
	private void Update()
	{
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
    #endregion


    #region Public Methods
    #endregion


    #region Protected Methods
    #endregion


    #region Private Methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Boundary"))
        {
			Destroy(this.gameObject);
        }
		if(collision.gameObject.CompareTag("Invader"))
        {
			Destroy(this.gameObject);
        }
    }
    #endregion
}
