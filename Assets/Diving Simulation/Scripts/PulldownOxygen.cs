<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PulldownOxygen : MonoBehaviour
{
    private TextMeshProUGUI statusTextOxygen;
    //private TextMeshPro statusTextBattery;
    //private TextMeshPro statusTextDepth;
    //private TextMeshPro statusTextDuration;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        statusTextOxygen = this.GetComponent<TextMeshProUGUI>();
        setMaxOxygenLevel(iM.GetMaxOxygenLevel());
        
    }

    
    public void setMaxOxygenLevel(float maxLevel)
    {
        int maxOxygenLevel = (int) maxLevel;
        statusTextOxygen.SetText("Oxygen:\n{0}%", maxLevel);
    }

    public void setOxygenLevel(float level) 
    {
        int currentOxygenLevel = (int) level;
        statusTextOxygen.SetText("Oxygen:\n{0}%", currentOxygenLevel);
    }

    // Update is called once per frame
    void Update()
    {
        setOxygenLevel(iM.GetOxygenLevel());
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PulldownOxygen : MonoBehaviour
{
    private TextMeshProUGUI statusTextOxygen;
    //private TextMeshPro statusTextBattery;
    //private TextMeshPro statusTextDepth;
    //private TextMeshPro statusTextDuration;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        statusTextOxygen = this.GetComponent<TextMeshProUGUI>();
        setMaxOxygenLevel(iM.GetMaxOxygenLevel());
        
    }

    
    public void setMaxOxygenLevel(float maxLevel)
    {
        int maxOxygenLevel = (int) maxLevel;
        statusTextOxygen.SetText("Oxygen:\n{0}%", maxLevel);
    }

    public void setOxygenLevel(float level) 
    {
        int currentOxygenLevel = (int) level;
        statusTextOxygen.SetText("Oxygen:\n{0}%", currentOxygenLevel);
    }

    // Update is called once per frame
    void Update()
    {
        setOxygenLevel(iM.GetOxygenLevel());
    }
}
>>>>>>> c7599d6b63380af63c5a5987f765fa993108de22
