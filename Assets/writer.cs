using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class writer : MonoBehaviour
{

    //Animator anim;
    string path;

    // Use this for initialization
    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
        //UnityEngine.Quaternion toPrint = anim.GetBoneTransform(HumanBodyBones.Hips).rotation;
        //Debug.Log((Time.frameCount).ToString() + (toPrint));

    }

    // Update is called once per frame
    void Update()
    {
        path = @"C:\Users\bobth\Documents\College\Summer17\vr\motion-capture\Assets\results.csv";
        using (StreamWriter sw = File.AppendText(path))
        {
            Transform[] allChildren = GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                string rotation = child.rotation.ToString().Substring(1,child.rotation.ToString().Length-2);
                string component = child.ToString().Substring(0, child.ToString().Length - 24);
                sw.WriteLine(component+',' + rotation +','+ Time.frameCount.ToString());
            }
        }
    }
}


