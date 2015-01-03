using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {
	NavMeshAgent navAgent;

	// Use this for initialization
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NavtoTarget(GameObject target) {
		navAgent.SetDestination (target.transform.position);

	}

	void Stop () {
		navAgent.Stop ();
	}

	public bool HasArrived() {
		if (navAgent.remainingDistance <= navAgent.stoppingDistance) {
			return true;
				}
		return false;
	}
}
