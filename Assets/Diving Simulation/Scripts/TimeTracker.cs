<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeTracker : MonoBehaviour
{
    private TextMeshProUGUI statusTextTime;
    public InformationManager iM;

    bool isUnderWater = false;
    bool prevState = false;
    float timeElapse = 0.0f;
    int seconds;


    // Start is called before the first frame update
    void Start()
    {
        statusTextTime = GetComponent<TextMeshProUGUI>();
        statusTextTime.SetText("Duration:\n{0}s", 0);

    }

    // Update is called once per frame
    void Update()
    {
        float underwaterDepth = iM.GetDepth();

        if(underwaterDepth < 0f) {
            prevState = isUnderWater;
            isUnderWater = true;
            
        } else {
            prevState = isUnderWater;
            isUnderWater = false;


        }

        if(prevState && isUnderWater) {
            timeElapse += Time.deltaTime;
            seconds = (int) timeElapse % 60;
            Debug.Log("I am under water \n");
            Debug.Log(seconds);
            statusTextTime.SetText("Duration:\n{0}s", seconds);
        } else
        {
            statusTextTime.SetText("Duration:\n{0}s", 0);
            timeElapse = 0.0f;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeTracker : MonoBehaviour
{
    private TextMeshProUGUI statusTextTime;
    public InformationManager iM;

    bool isUnderWater = false;
    bool prevState = false;
    float timeElapse = 0.0f;
    int seconds;


    // Start is called before the first frame update
    void Start()
    {
        statusTextTime = GetComponent<TextMeshProUGUI>();
        statusTextTime.SetText("Duration:\n{0}s", 0);

    }

    // Update is called once per frame
    void Update()
    {
        float underwaterDepth = iM.GetDepth();

        if(underwaterDepth < 0f) {
            prevState = isUnderWater;
            isUnderWater = true;
            
        } else {
            prevState = isUnderWater;
            isUnderWater = false;
            statusTextTime.SetText("Duration:\n{0}s", seconds);


        }

        if(!prevState && isUnderWater) {
            timeElapse += Time.deltaTime;
            seconds = (int) timeElapse;
            Debug.Log("I am under water \n");
            Debug.Log(seconds);
            statusTextTime.SetText("Duration:\n{0}s", seconds);
        } 
    }
}
>>>>>>> c7599d6b63380af63c5a5987f765fa993108de22
