using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLD : MonoBehaviour {
    public GameObject game;
    public GameObject[] gos;
    int i = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < game.transform.childCount; i++)
        {
            game.transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.position = game.transform.position;
        transform.eulerAngles = game.transform.eulerAngles;
	}
    private void OnCollisionEnter(Collision collision)
    {
        print("碰撞");
        if (collision.transform.tag == "Bug")
        {
            collision.transform.gameObject.SetActive(false);
            if (i<=8)
            {
                i++;
                gos[i].SetActive(true);
            }
        }
    }
}
