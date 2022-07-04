using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishbarScript : MonoBehaviour
{
    int fishpattern;
    float add;
    Transform barTransform;
    Vector2 pos;

    private Image image;
    private Sprite sprite;

    private int fish_num = 0;

    [SerializeField] GameObject successPanel;
    [SerializeField] GameObject failurePanel;
    [SerializeField] GameObject fishshadowImage;
    [SerializeField] GameObject fishImage;

    // Start is called before the first frame update
    void Start()
    {

        fishpattern = Random.Range(1, 10);
        if(fishpattern >= 1 && fishpattern < 5)
        {
            add = 0.2f;
            sprite = Resources.Load<Sprite>("fish");
            fish_num = 1;
        }
        else if(fishpattern >= 5 && fishpattern < 8)
        {
            add = 0.25f;
            sprite = Resources.Load<Sprite>("tai");
            fish_num = 2;
        }
        else if(fishpattern >= 8)
        {
            add = 0.3f;
            sprite = Resources.Load<Sprite>("tuna");
            fish_num = 3;
        }
        image = fishshadowImage.GetComponent<Image>();
        image.color = new Color32(0, 0, 0, 255);
        image.sprite = sprite;
        fishshadowImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void FixedUpdate()
    {

        barTransform = this.transform;

        pos = barTransform.position;


        if (pos.x >= 5.316804)
        {
            add = -add;
        }
        else if (pos.x <= -5.316804)
        {
            add = -add;
        }

        pos.x += add;

        barTransform.position = pos;

        //Debug.Log(pos.x);
    }

    public void onClicked_stop()
    {
        add = 0;
        if(pos.x <= 1.93014 && -1.930138 <= pos.x)
        {
            successPanel.SetActive(true);
            image = fishImage.GetComponent<Image>();
            image.sprite = sprite;
            fishImage.SetActive(true);
            if(fish_num == 1)
            {
                GManager.instance.coin += 10;
            } else if(fish_num == 2)
            {
                GManager.instance.coin += 30;
            } else
            {
                GManager.instance.coin += 50;
            }
        } else
        {
            failurePanel.SetActive(true);
        }
    }
}
