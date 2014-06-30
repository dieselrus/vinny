using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	public Transform bee;
	public int beeCount;

	private Vector2 mapSize = new Vector2(30, 20);
	// Use this for initialization
	void Start () {
		generateMap();
	}

	void generateMap()
	{
		for (int i = 0; i < beeCount; i++)
		{
			Instantiate(bee, new Vector2(Random.Range(0, mapSize.x),
			                             Random.Range(0, mapSize.y)), bee.rotation);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
