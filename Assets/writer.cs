using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class writer : MonoBehaviour {

    Animator anim;
    public Transform bits;
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {

        //Debug.Log(anim.GetBoneTransform());
        //System.IO.File.WriteAllText("path", contents)	
        Debug.Log(anim.GetBoneTransform());
       
	}
}
