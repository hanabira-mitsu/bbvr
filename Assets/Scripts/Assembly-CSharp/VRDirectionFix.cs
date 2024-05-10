using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDirectionFix : MonoBehaviour
{
    public GameObject XRRig;
    public GameObject MainCam;
    // Start is called before the first frame update
    void Start()
    {
        MainCam.transform.eulerAngles = new Vector3(XRRig.transform.eulerAngles.x, XRRig.transform.eulerAngles.y, XRRig.transform.eulerAngles.z);
        Debug.Log("Angle Changed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
