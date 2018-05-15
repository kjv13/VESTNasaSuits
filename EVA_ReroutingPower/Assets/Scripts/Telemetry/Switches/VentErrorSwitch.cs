﻿using UnityEngine;
using UnityEngine.UI;


public class VentErrorSwitch : MonoBehaviour
{
    Text value;
    private float nextTime = 0.0f;
    public float period = 1f;
  //  public static Color CRITICAL_BACKGROUND_COLOR = Color.red;
   // GameObject heart_rate_obj;

    //GameObject external_environment_pressure_obj;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateValue(int contrast_idx)
    {
        value = transform.Find("value_position").transform.GetComponentInChildren<Text>();
        string switchStatus = TelemetryController.suitSwitch.vent_error;
        
        value.text = TelemetryController.suitSwitch.vent_error;
        if (switchStatus == "1")
        {

                transform.GetComponent<Image>().color = Color.red;
          
        }
        else
        {
           
            transform.GetComponent<Image>().color = Color.grey;
           
        }
    }
}
