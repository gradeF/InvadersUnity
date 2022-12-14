using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderTrigger : MonoBehaviour
{
    #region Public Fields
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
		
	}
    #endregion


    #region Public Methods
    #endregion


    #region Protected Methods
    #endregion


    #region Private Methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Laser"))
        {
            GameManager.instance.Invaders.Remove(gameObject);
            Destroy(this.gameObject);
            GameManager.instance.AddScore(10);
        }
    }
    #endregion
}
