using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class NumberPad : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField inputHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject buttonClear;
    public GameObject buttonDelete;

    public string input;

    public void b1() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "1";
        } else {
            inputHolder.text = inputHolder.text + "1";
        }
    }
    public void b2() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "2";
        } else {
            inputHolder.text = inputHolder.text + "2";
        }
    }
    public void b3() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "3";
        } else {
            inputHolder.text = inputHolder.text + "3";
        }
    }
    public void b4() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "4";
        } else {
            inputHolder.text = inputHolder.text + "4";
        }
    }
    public void b5() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "5";
        } else {
            inputHolder.text = inputHolder.text + "5";
        }
    }
    public void b6() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "6";
        } else {
            inputHolder.text = inputHolder.text + "6";
        }
    }
    public void b7() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "7";
        } else {
            inputHolder.text = inputHolder.text + "7";
        }
    }
    public void b8() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "8";
        } else {
            inputHolder.text = inputHolder.text + "8";
        }
    }
    public void b9() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "9";
        } else {
            inputHolder.text = inputHolder.text + "9";
        }
    }
    public void b0() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "" + "0";
        } else {
            inputHolder.text = inputHolder.text + "0";
        }
    }
    public void bClear() {
        if (inputHolder.text == "Enter 4 Digit Frequency Here\n") {
            inputHolder.text = "";
        } else {
            string value = inputHolder.text;
            value = value.Substring(0, value.Length - 1);
            inputHolder.text = value;
        }
    }
    public void bDelete() {
        inputHolder.text = "";
    }


    
    void Start()
    {
        inputHolder.text= "Enter 4 Digit Frequency Here\n";
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
