using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerMove : MonoBehaviour
{
	private GameObject player;
	private List<Node> final;

	private float MoveSpeed = 300f;//adjust thisfor the speed of the ai
	float Timer;
	static Vector3 CurrentPositionHolder;
	private Vector3 startPosition;
	int currentNode = 0;

	private float orginalY;

    void Start()
	{
		final = Grid.FinalPath;
		player = GameObject.Find("Computer(Clone)");
		orginalY = player.transform.position.y;
		CheckNode();
	}

	

	void CheckNode()
	{
		Timer = 0f;
		startPosition = player.transform.position;
		CurrentPositionHolder = final[currentNode].vPosition;
		CurrentPositionHolder.y = orginalY;
		Debug.Log(CurrentPositionHolder + "   " + startPosition);
	}

	// Update is called once per frame
	void Update()
	{
		Timer += Time.deltaTime * MoveSpeed;
		if (player.transform.position != CurrentPositionHolder)
		{
			player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
		}
		else
		{
			if (currentNode < final.Count - 1)
			{
				currentNode++;
				CheckNode();
			}
		}
	}
}
