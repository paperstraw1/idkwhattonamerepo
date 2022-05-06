using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalacticCreditScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            CORE.playHanVoice();
            CORE.score++;
            CORE.TimerOn = true;
            Destroy(this.gameObject);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}