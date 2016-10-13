using UnityEngine;
using System.Collections;

public class CheckNeigbours : MonoBehaviour {

    public int rc;
    public float moveSpeed;

    private SphereCollider collider;

	// Use this for initialization
	void Start () {
        collider = transform.GetComponent<SphereCollider>();
	}
	
	void OnTriggerEnter() {
        Vector3 position = transform.parent.position;
        transform.parent.position = new Vector3(position.x, position.y, position.z + moveSpeed);
    }
}
