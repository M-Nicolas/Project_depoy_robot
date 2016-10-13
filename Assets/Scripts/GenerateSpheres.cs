using UnityEngine;
using System.Collections;

public class GenerateSpheres : MonoBehaviour {

    public static bool generate;
    public GameObject robot;

	// Use this for initialization
	void Start () {
        Instantiate(robot);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
