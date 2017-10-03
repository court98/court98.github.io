using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathscript : MonoBehaviour {
    private GameObject bomb;
    public Vector3 checkpoint;
    public Transform player;

	// Use this for initialization
	void Start () {
        checkpoint = new Vector3(-7, 0, -8);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== ("Player")) 

        {
            player.transform.position = checkpoint=new Vector3(-7, 1, -8);
        }
   

    }
    // Update is called once per frame
    void Update () {
		
	}
}
