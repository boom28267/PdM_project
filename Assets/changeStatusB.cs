using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class changeStatusB : MonoBehaviour
{
    public TextMesh machineTextB;
    public TextMesh tempTextB;
    public TextMesh RPMTextB;
    public TextMesh VoltTextB;
    public TextMesh xaxisTextB;
    public TextMesh yaxisTextB;
    public TextMesh zaxisTextB;

    string jsonDataB;

    // Use this for initialization
    void Start()
    {


        machineTextB.text = "--";
        tempTextB.text = "--";
        RPMTextB.text = "--";
        VoltTextB.text = "--";
        xaxisTextB.text = "--";
        yaxisTextB.text = "--";
        zaxisTextB.text = "--";
    }


    // Update is called once per frame
    void Update()
    {

        string urlB = "http://161.246.6.140:8000/PDM/api/?ID=MC-02";
        WWW wwwB = new WWW(urlB);
        StartCoroutine(WaitForRequest(wwwB));
        

    }

    IEnumerator WaitForRequest(WWW www)
    {
        Debug.Log("B");
        yield return www;

        jsonDataB = www.text;
        JSONNode jsonNodeB = SimpleJSON.JSON.Parse(jsonDataB);

        Debug.Log("Time: " + jsonNodeB[0]["Time"].ToString());
        Debug.Log("RPM: " + jsonNodeB[0]["RPM"].ToString());
        Debug.Log("Temperature: " + jsonNodeB[0]["Temperature"].ToString());
        Debug.Log("Xaxis: " + jsonNodeB[0]["Xaxis"].ToString());
        Debug.Log("Yaxis: " + jsonNodeB[0]["Yaxis"].ToString());
        Debug.Log("Zaxis: " + jsonNodeB[0]["Zaxis"].ToString());
        Debug.Log("Volt: " + jsonNodeB[0]["Volt"].ToString());
        Debug.Log("Amp: " + jsonNodeB[0]["Amp"].ToString());
        
        machineTextB.text = jsonNodeB[0]["Time"].ToString();
        tempTextB.text = jsonNodeB[0]["Temperature"].ToString();
        RPMTextB.text = jsonNodeB[0]["RPM"].ToString();
        VoltTextB.text = jsonNodeB[0]["Volt"].ToString();
        xaxisTextB.text = jsonNodeB[0]["Xaxis"].ToString();
        yaxisTextB.text = jsonNodeB[0]["Yaxis"].ToString();
        zaxisTextB.text = jsonNodeB[0]["Zaxis"].ToString();






    }
}
