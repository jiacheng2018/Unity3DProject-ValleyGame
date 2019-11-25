using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WL : MonoBehaviour {
    /// <summary>
    ///  速度
    /// </summary>
    public float s = 1;

    public HapticPulseClass haptic;
    public AudioSource source;
    public Image im;
    bool isA;
    bool isR;
    bool isI;
    // Use this for initialization
    void Start()
    {

    }
    public void StartAnimator()
    {
        if (isR)
        {
            haptic.StartGame();
        }
        if (isA)
        {
            //source.Play();
            Instantiate(source.gameObject).SetActive(true);
        }
        
        
    }

    // Update is called once per frame
    void Update () {
        GetComponent<Animator>().speed = s;
      
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isA = true;
            isI = true;
            isR = false;
            im.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            isA = false;
            isI = true;
            isR = true;
            im.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            isA = true;
            isI = false;
            isR = true;
            im.enabled = false;
        }
    }
 
}
