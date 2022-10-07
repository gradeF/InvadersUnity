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
	private float maxTime = 1.0f;
	private float time;
	#endregion


	#region MonoBehaviour Callbacks
	private void Start()
	{
		
	}
	private void Update()
	{
		time += Time.deltaTime;
		if(time >= maxTime)
        {
			LaserShoot();
			
		}
		
	}
	#endregion


	#region Public Methods
	#endregion


	#region Protected Methods
	#endregion


	#region Private Methods
	private void LaserShoot()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (laser != null)
			{
				Instantiate(laser, transform.position, transform.rotation);
				time = 0.0f;
			}
		}
	}
	#endregion
}
