using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarManager : MonoBehaviour
{
    #region Public Fields
    public GameObject starObject;
    public int starCount = 300;
    #endregion

    #region Private Fields

    #endregion

    #region MonoBehaviour Callbacks
    void Start()
    {
        for(int i = 0; i<300; i++)
        {
            Instantiate(starObject, transform);
        }
    }

    void Update()
    {
        
    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion
}

