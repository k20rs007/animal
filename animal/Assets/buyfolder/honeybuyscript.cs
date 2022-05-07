using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class honeybuyscript : MonoBehaviour
{
    [SerializeField] GameObject noPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked_honeybutton()
    {
        if(!GManager.instance.honey && GManager.instance.coin >= 5 && GManager.instance.houselevel >= 1 && !GManager.instance.paint_honey)
        {
            GManager.instance.honey = true;
            GManager.instance.coin -= 5;
        }else
        {
            noPanel.SetActive(true);
        }
    }
}
