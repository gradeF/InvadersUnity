using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartManager : MonoBehaviour
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
		if(Input.GetKeyDown(KeyCode.Return))
        {
			SceneManager.LoadScene("01Game");
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
