using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterWarning : MonoBehaviour
{

    public InformationManager iM;
    private AudioSource warningAS;

    bool isUnderwater = false;
    bool prevState = false;
    bool audioFinished = true;

    // Start is called before the first frame update
    void Start()
    {
        warningAS = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        float currDepth = iM.GetDepth();
        //Debug.Log("The current depth is " + currDepth.ToString());

        if(currDepth < 0f)
        {
            prevState = isUnderwater;
            isUnderwater = true;
        } else
        {
            prevState = isUnderwater;
            isUnderwater = false;
        }

        if(!prevState && isUnderwater && audioFinished)
        {
            Debug.Log("I am under water. Let's try to play the audio!");
            // Play audio here.
            StartCoroutine(AudioCompletion());

        }
    }

    IEnumerator AudioCompletion()
    {
        audioFinished = false;
        warningAS.Play();
        yield return new WaitForSeconds(warningAS.clip.length);
        audioFinished = true;
    }

}
