using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreTexte;
    public Text ballTexte;
    public GameObject ballModel;

    private int score = 0;
    private int ballNumber = 10;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        scoreTexte.text = "Score = " + score;
        ballTexte.text = "Balls = " + ballNumber;

        Vector3 ballPos = new Vector3(0, 8.88f, -0.154f);
        if (Input.GetButtonDown("Fire1") && ballNumber > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                ballPos.x = ray.GetPoint(10).x;
                Instantiate(ballModel, ballPos, transform.rotation);
                --ballNumber;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score++;
            ballNumber++;
        }
    }
}
