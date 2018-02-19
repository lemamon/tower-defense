using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enimy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        GameObject endPath = GameObject.Find("EndPath");
        Vector3 endPathPosition = endPath.transform.position;

        agent.SetDestination(endPathPosition);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
