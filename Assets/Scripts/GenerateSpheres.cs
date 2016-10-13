using UnityEngine;
using System.Collections;

public class GenerateSpheres : MonoBehaviour {

    public static bool generate = false;
    public GameObject robot;
    public float waitTime;

    private bool wait;
    private float previousTime;


	// Use this for initialization
	void Start () {
        Instantiate(robot);
        wait = false;
        previousTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (generate) {
            Instantiate(robot);
        }

        GameObject[] list = GameObject.FindGameObjectsWithTag("Robots");

        if (!wait) {
            previousTime = Time.time;
            for (int i = 0; i < list.Length; i++) {
                Vector3 position = list[i].transform.position;
                list[i].transform.position = new Vector3(position.x, position.y, position.z + 5);
            }
            wait = true;
            generate = true;
        } else {
            if (previousTime < Time.time - waitTime) {
                wait = false;
            }
            generate = false;
        }
    }
}
