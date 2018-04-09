using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeText : MonoBehaviour {

    public TextMesh machineText;
    public TextMesh tempText;
    public TextMesh RPMText;
    public TextMesh VoltText;
    public TextMesh xaxisText;
    public TextMesh yaxisText;
    public TextMesh zaxisText;

    // Use this for initialization
    void Start () {
        

        machineText.text =  "--";
        tempText.text = "--";
        RPMText.text = "--";
        VoltText.text = "--";
        xaxisText.text = "--";
        yaxisText.text = "--";
        zaxisText.text = "--";
    }

	
	// Update is called once per frame
	void Update () {
        //machineText.text = "MachineX";
        //tempText.text = "temp = 123";
        //RPMText.text = "321";
        //VoltText.text = "654";
        //xaxisText.text = "987";
        //yaxisText.text = "789";
        //zaxisText.text = "694";

    }
}
