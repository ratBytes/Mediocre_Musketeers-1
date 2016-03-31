﻿using UnityEngine;
using System.Collections;

public class ScriptDetectionDebugging : MonoBehaviour {
    [Tooltip("The attack sphere of this enemy.")]
    public SphereCollider attackSphere;
    [Tooltip("The detection sphere of this enemy.")]
    public SphereCollider detectSphere;
    [Tooltip("The sphere used to keep enemies from bumping into each other. Not Implemented.")]
    public SphereCollider separationSphere;

    // Use this for initialization
    void Start () {
        //mod by Victor Haskins. Delete if not working or necessary
        if (detectSphere == null)
            Debug.Log("Detect Sphere is not set. Please set in prefab.");
        if (attackSphere == null)
            Debug.Log("Attack Sphere is not set. Please set in prefab.");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        //mod by Victor Haskins. Delete if not working or necessary
        if(detectSphere != null)
            Gizmos.DrawWireSphere(transform.position, detectSphere.radius);
        Gizmos.color = Color.red;
        //mod by Victor Haskins. Delete if not working or necessary
        if (attackSphere != null)
            Gizmos.DrawWireSphere(transform.position, attackSphere.radius);
        //Gizmos.color = Color.black;
        //Gizmos.DrawWireSphere(transform.position, separationSphere.radius);
    }
}
