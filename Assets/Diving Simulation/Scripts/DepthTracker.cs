using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepthTracker : MonoBehaviour
{
    private TextMeshProUGUI statusTextDepth;
    public InformationManager iM;

    bool isUnderWater = false;
    bool prevState = false;

    // Start is called before the first frame update
    void Start()
    {
        statusTextDepth = this.GetComponent<TextMeshProUGUI>();
        statusTextDepth.SetText("Depth:\n{0}m", 0);
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

        if(!prevState && isUnderWater) {
            statusTextDepth.SetText("Depth:\n{0}m", -1*underwaterDepth);
        }

        
    }
}
