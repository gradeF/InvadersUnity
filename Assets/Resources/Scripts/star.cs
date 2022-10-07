using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    #region Public Fields
    #endregion

    #region Private Fields
    private SpriteRenderer _sprite;
    #endregion

    #region MonoBehaviour Callbacks
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        if (_sprite == null)
        {
            Debug.Log("isNULL");
        }
        Vector3 position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-5.0f, 5.0f));
        _sprite.color = new Color32((byte)Random.Range(0,255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        this.transform.position = position;
    }

    void Update()
    {
        StartCoroutine(Twinkle());
    }
    #endregion

    #region Public Methodss
    #endregion

    #region Private Methods
    IEnumerator Twinkle()
    {
        yield return null;
    }
    #endregion
}

