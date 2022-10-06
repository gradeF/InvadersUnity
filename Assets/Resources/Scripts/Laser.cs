using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	#region Public Fields
	[SerializeField]
	private GameObject laser;
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
		if(Input.GetKeyDown(KeyCode.Space))
        {
			if(laser != null)
            {
				Instantiate(laser, transform.position, transform.rotation);
            }
        }
	}
	#endregion


	#region Public Methods
	#endregion


	#region Protected Methods
	#endregion


	#region Private Methods
	#endregion
}
