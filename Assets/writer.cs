using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class writer : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        Transform hipTransform = anim.GetBoneTransform(HumanBodyBones.Hips);



    }

    // Update is called once per frame
    void Update () {
        



        //System.IO.File.WriteAllText("path", contents)

    



        //UnityEngine.Quaternion toPrint = anim.GetBoneTransform(HumanBodyBones.Hips).rotation;

        //Debug.Log(hipTransform.GetChildCount());

        //Debug.Log((Time.frameCount).ToString() + (toPrint));

    }

    void traverse (Transform parent)
    {
        foreach (Transform child in parent)
        {
            Debug.Log(child.ToString());
        }
    }


}
