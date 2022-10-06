using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Fields
    public GameObject[] lifelist;
    #endregion

    #region Private Fields
    private bool isDead = false;
    private static int life = 3;
    [SerializeField]
    private float playerSpeed = 3.0f;
    #endregion

    #region MonoBehaviour Callbacks
    void Start()
    {
        
    }
    
    void Update()
    {
        Move();
    }
    #endregion


    #region Public Methods
    #endregion

    #region Prvate Methods
    private void Move()
    {
        float moveX = playerSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(moveX, 0, 0);

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        viewPos.x = Mathf.Clamp01(viewPos.x);

        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);
        transform.position = worldPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Invader") || collision.gameObject.CompareTag("Attack"))
        {
            life--;
            switch(life)
            {
                case 2:
                    lifelist[2].SetActive(false);
                    break;
                case 1:
                    lifelist[1].SetActive(false);
                    break;
                case 0:
                    lifelist[0].SetActive(false);
                    isDead = true;
                    GameManager.instance.OnPlayerDead();
                    break;
            }
            
        }
        
    }
    #endregion
}