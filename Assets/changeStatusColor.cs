using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeStatusColor : MonoBehaviour {

    public Material machineMat;
    public Material tempMat;
    public Material RPMMat;
    public Material voltMat;
    public Material axisMat;

    public Color machineNormalColor;
    public Color machineAbnormalColor;
    public Color tempNormalColor;
    public Color tempAbnormalColor;
    public Color RPMNormalColor;
    public Color RPMAbnormalColor;
    public Color voltNormalColor;
    public Color voltAbnormalColor;
    public Color axisNormalColor;
    public Color axisAbnormalColor;

    // Use this for initialization
    void Start()
    {
        //GetComponent<Renderer>().material.SetColor("_Color", machineNormalColor);
        machineMat.color = Color.black;
        tempMat.color = Color.black;
        RPMMat.color = Color.black;
        voltMat.color = Color.black;
        axisMat.color = Color.black;


    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Renderer>().material.SetColor("_Color", machineAbnormalColor);
        

        //machineMat.color = machineAbnormalColor;
        //tempMat.color = tempNormalColor;
        //RPMMat.color = RPMNormalColor;
        //voltMat.color = voltNormalColor;
        //axisMat.color = axisAbnormalColor;

    }
}
