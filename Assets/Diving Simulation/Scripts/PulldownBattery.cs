using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PulldownBattery : MonoBehaviour
{

    public InformationManager iM;
    private TextMeshProUGUI statusBatteryLevelText;
    // Start is called before the first frame update
    void Start()
    {
        statusBatteryLevelText = this.GetComponent<TextMeshProUGUI>();
        statusBatteryLevelText.SetText("Battery:\n{0}%", 0);
    }

    // Update is called once per frame
    void Update()
    {
        float currBatteryLevel = (iM.GetBatteryLevel() / iM.GetMaxBatteryLevel()) * 100;
        int displayBatteryLevel = (int) currBatteryLevel;
        statusBatteryLevelText.SetText("Battery:\n{0}%", displayBatteryLevel);
    }
}
