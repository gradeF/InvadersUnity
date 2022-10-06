using UnityEngine;

public class Invader : MonoBehaviour
{
	#region Public Fields
	public Sprite[] animationSprites;
	public float animationTime = 1.0f;
	#endregion


	#region Protected Fields
	#endregion


	#region Private Fields
	private SpriteRenderer _spriteRenderer;
	private int _animationFrame;
    #endregion


    #region MonoBehaviour Callbacks
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprites), this.animationTime, this.animationTime);
    }
    #endregion


    #region Public Methods
    #endregion


    #region Protected Methods
    #endregion


    #region Private Methods
    private void AnimateSprites()
    {
        _animationFrame++;
        if(_animationFrame >= this.animationSprites.Length)
        {
            _animationFrame = 0;
        }

        _spriteRenderer.sprite = this.animationSprites[_animationFrame];
    }
    #endregion
}
