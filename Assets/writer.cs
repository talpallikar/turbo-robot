using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class writer : MonoBehaviour
{

    Animator anim;
    string path;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        path = @"C:\Users\bobth\Documents\College\Summer17\vr\motion-capture\Results\results.csv";
        using (StreamWriter sw = File.AppendText(path))
        {
            //GCPrint(sw);
            MecanimPrint(sw);
        }
    }

    //recursively get all children of the GO, and then call FmtPrint()
    void GCPrint(StreamWriter sw)
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            string rotation = child.rotation.ToString();
            string component = child.ToString().Substring(0, child.ToString().Length - 24);
            FmtPrint(sw, rotation, component);
        }
    }

    //iterate over HumanBodyBones enumerable, and then call FmtPrint()
    void MecanimPrint(StreamWriter sw)
    {
        foreach (HumanBodyBones bone in System.Enum.GetValues(typeof(HumanBodyBones)))
        {
            if (anim.GetBoneTransform(bone)!=null)
            {
                string rotation = anim.GetBoneTransform(bone).rotation.ToString();
                string component = bone.ToString();
                FmtPrint(sw, rotation, component);
            }
        }
    }

    void FmtPrint(StreamWriter sw, string rotation, string component)
    {
        sw.WriteLine(component + ',' + rotation.Substring(1, rotation.Length - 2) + ',' + Time.frameCount.ToString());
    }

}


