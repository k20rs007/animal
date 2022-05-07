using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyscript : MonoBehaviour
{

    [SerializeField] GameObject checkPanel;
    [SerializeField] GameObject noPanel;

    public AudioClip buy_se;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked_housebutton()
    {
        if(GManager.instance.houselevel == 0)
        {
            if(GManager.instance.coin >= 50)
            {
                checkPanel.SetActive(true);
            } else
            {
                noPanel.SetActive(true);
            }
        } else if(GManager.instance.houselevel == 1)
        {
            if(GManager.instance.coin >= 100)
            {
                checkPanel.SetActive(true);
            } else
            {
                noPanel.SetActive(true);
            }
        }
    }

    public void onClicked_houseokbutton()
    {
        if(GManager.instance.houselevel == 0)
        {
            GManager.instance.coin -= 50;
            GManager.instance.houselevel++;
        } else
        {
            GManager.instance.coin -= 100;
            GManager.instance.houselevel++;
        }
        //audioSource.PlayOneShot(buy_se);
        checkPanel.SetActive(false);
    }

    public void onClicked_housenobutton()
    {
        checkPanel.SetActive(false);
    }

    public void onClicked_closebutton()
    {
        noPanel.SetActive(false);
    }
}
