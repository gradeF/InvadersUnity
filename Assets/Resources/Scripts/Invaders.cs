using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invaders : MonoBehaviour
{
	#region Public Fields
	public GameObject[] prefabs;
	public int row = 5;
	public int col = 6;
    #endregion


    #region Protected Fields
    #endregion


    #region Private Fields
    #endregion


    #region MonoBehaviour Callbacks
    private void Awake()
    {
        for(int rows = 0; rows<this.row; rows++)
        {
			Vector3 rowPosition = new Vector3(0.0f, rows * 0.8f, 0.0f);
			for(int cols = 0; cols<this.col; cols++)
            {
				GameObject invader = Instantiate(this.prefabs[rows], this.transform);
				Vector3 position = rowPosition;
				position.x += cols * 0.8f;
				invader.transform.position = position;
            }
        }
    }
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
	#endregion
}
