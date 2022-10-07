using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderMove : MonoBehaviour
{
	#region Public Fields
	[SerializeField]
	private float moveSpeed = 1.0f;
	#endregion


	#region Protected Fields

	#endregion


	#region Private Fields
	private Vector3 direction = Vector2.left;
	#endregion


	#region MonoBehaviour Callbacks
	private void Start()
	{
		
	}
	private void Update()
	{
		transform.position += direction * moveSpeed * Time.deltaTime;
		Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
		Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
		if (direction == Vector3.left && transform.position.x <= leftEdge.x)
        {
			InvadersMove();
        }
		else if(direction == Vector3.right && transform.position.x >= (rightEdge.x -4.0f))
        {
			InvadersMove();
        }

    }
	private void InvadersMove()
    {
		direction.x *= -1.0f;
		Vector3 position = this.transform.position;
		position.y -= 1.0f;
		this.transform.position = position;
    }
	#endregion


	#region Public Methods
	#endregion


	#region Protected Methods
	#endregion


	#region Private Methods
	#endregion
}
