using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class changeStatus : MonoBehaviour
{
    public TextMesh machineTextA;
    public TextMesh tempTextA;
    public TextMesh RPMTextA;
    public TextMesh VoltTextA;
    public TextMesh xaxisTextA;
    public TextMesh yaxisTextA;
    public TextMesh zaxisTextA;
    public int i;
    public int j;

    string jsonDataA;

    // Use this for initialization
    void Start()
    {
        i = 0;
        j = 0;
        

        machineTextA.text = "--";
        tempTextA.text = "--";
        RPMTextA.text = "--";
        VoltTextA.text = "--";
        xaxisTextA.text = "--";
        yaxisTextA.text = "--";
        zaxisTextA.text = "--";


    }


    // Update is called once per frame
    void Update()
    {

        //string url = "http://161.246.6.140:8000/PDM/api/?ID=MC-03";
        //WWW www = new WWW(url);
        //StartCoroutine(WaitForRequest(www));


        //machineText.text = "MachineX";
        //tempText.text = "temp = 123";
        //RPMText.text = "321";
        //VoltText.text = "654";
        //xaxisText.text = "987";
        //yaxisText.text = "789";
        //zaxisText.text = "694";
        
        
        if (i < 200)
        {
            i++;
        }
        else if (i == 200)
        {
            Vuforia.DefaultSmartTerrainEventHandler stat = new Vuforia.DefaultSmartTerrainEventHandler();

            asdf();
            i = 0;
            j += 1;

        }
        else
        {
            i = 0;
            Debug.Log("what");
        }

    }

    void asdf()
    {
        Debug.Log("yes"+i+"-"+j);

    }

    //IEnumerator WaitForRequest(WWW www)
    //{
    //    yield return www;
    //    yield return new WaitForSeconds(10000);
    //    StartCoroutine(Example());
    //    Debug.Log("delay");

    //    jsonDataA = www.text;
    //        JSONNode jsonNode = SimpleJSON.JSON.Parse(jsonDataA);
    //        //Debug.Log ("jsonNode: " + jsonNode.ToString());
    
    //        Debug.Log("RPM: " + jsonNode[0]["RPM"].ToString());
    //        Debug.Log("Temperature: " + jsonNode[0]["Temperature"].ToString());
    //        Debug.Log("Xaxis: " + jsonNode[0]["Xaxis"].ToString());
    //        Debug.Log("Yaxis: " + jsonNode[0]["Yaxis"].ToString());
    //        Debug.Log("Zaxis: " + jsonNode[0]["Zaxis"].ToString());
    //        Debug.Log("Volt: " + jsonNode[0]["Volt"].ToString());
    //        Debug.Log("Amp: " + jsonNode[0]["Amp"].ToString());

    //    //For Image
    //    //string getJSONImg = jsonNode[0]["thumbnail"].ToString();
    //    //string replaceQuote = getJSONImg.Replace("\"", "");
    //    //urlImg = replaceQuote.Replace("\\", "");
    //    //WWW www_img = new WWW(urlImg);
    //    //yield return www_img;
    //    //img.sprite = Sprite.Create(www_img.texture, new Rect(0, 0, www_img.texture.width, www_img.texture.height), new Vector2(0, 0));

    //    //For Title


    //    machineTextA.text = jsonNode[0]["Time"].ToString();
    //    tempTextA.text = jsonNode[0]["Temperature"].ToString();
    //    RPMTextA.text = jsonNode[0]["RPM"].ToString();
    //    VoltTextA.text = jsonNode[0]["Volt"].ToString();
    //    xaxisTextA.text = jsonNode[0]["Xaxis"].ToString();
    //    yaxisTextA.text = jsonNode[0]["Yaxis"].ToString();
    //    zaxisTextA.text = jsonNode[0]["Zaxis"].ToString();






    //}
}
