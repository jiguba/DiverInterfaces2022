using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class OxygenBar : MonoBehaviour
{
    private Slider slider;
    public InformationManager iM;


    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        setMaxOxygenLevel(iM.GetMaxOxygenLevel());
    }

    public void setMaxOxygenLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
    }

    public void setOxygenLevel(float level) 
    {
        slider.value = level;
    }

    // Update is called once per frame
    private void Update()
    {
        setOxygenLevel(iM.GetOxygenLevel());
    }
}
