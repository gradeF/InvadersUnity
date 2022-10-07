using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Invaders : MonoBehaviour
{
	#region Public Fields
	public GameObject[] prefabs;
	public GameObject Laser;
	public float MaxTime = 2.0f;
	public int row = 5;
	public int col = 6;
	#endregion


	#region Protected Fields
	#endregion


	#region Private Fields
	float timer = 0.0f;
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
				GameManager.instance.Invaders.Add(invader);
			}
        }
    }
    private void Start()
	{
		
	}
	private void Update()
	{
		timer += Time.deltaTime;
		if(timer >= MaxTime)
        {
			Fire();
			timer = 0.0f;
        }
	}
	#endregion


	#region Public Methods
	#endregion


	#region Protected Methods
	#endregion


	#region Private Methods

	void Fire()
    {
		var invaderGroups = GameManager.instance.Invaders.GroupBy(i => i.transform.position.x);
		var randomGroup = invaderGroups.ElementAt(Random.Range(0, invaderGroups.Count()));
		var orderedGroup = randomGroup.OrderBy(i => i.transform.position.y);

		GameObject bottomInvader = orderedGroup.First();

		Instantiate(Laser, transform);
	}

	#endregion
}
