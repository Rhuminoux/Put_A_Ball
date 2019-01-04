using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

    public enum SIDE
    {
        LEFT,
        RIGHT
    }

    public SIDE side;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ///could have only use side as an int +1 -1 but enum is cooler u-u
        if (side == SIDE.RIGHT)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (float)0.03, gameObject.transform.position.y, gameObject.transform.position.z);
        else
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (float)0.03, gameObject.transform.position.y, gameObject.transform.position.z);
        if (side == SIDE.LEFT && transform.position.x < -2.3)
            side = SIDE.RIGHT;
        else if (side == SIDE.RIGHT && transform.position.x > 1.2) //////////////// moving side depends on the x position of the object
            side = SIDE.LEFT;
    }
}
