using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KirikabuScript : MonoBehaviour
{
    static DateTime dt;
    DateTime dt2;
    public Text text;

    static bool honey = false;

    public Image image;
    private Sprite sprite;
    int musi;
    int mushi_coin= 0;

    [SerializeField] GameObject kabutomusiImage;
    [SerializeField] GameObject kirakiraImage;
    [SerializeField] GameObject toFieldButton;
    [SerializeField] GameObject honeyPanel;

    // Start is called before the first frame update
    void Start()
    {
        //dt2 = DateTime.Now;
        //dt = DateTime.Now;
        Debug.Log(dt2);

        musi = UnityEngine.Random.Range(1, 10);
        Debug.Log(musi);

        if(honey == true)
        {
            kirakiraImage.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        Time();
    }

    void Time()
    {
        //TimeSpan ts1 = TimeSpan.Parse("dt");
        //TimeSpan ts2 = TimeSpan.Parse("dt2");

        DateTime dtNow = DateTime.Now;
        TimeSpan ts3 = DateTime.Now - dt;
        //Debug.Log(ts3.TotalMinutes);

        //Debug.Log(dt2.ToString());
        Debug.Log(dt);
        Debug.Log(honey);

        if (ts3.TotalMinutes > 0.1f && honey == true)
        {
            if (musi >= 1 && musi < 5) //Nomal
            {
                sprite = Resources.Load<Sprite>("tentoumusi");
                mushi_coin = 10;
            }
            else if (musi >= 5 && musi < 8) //R
            {
                sprite = Resources.Load<Sprite>("choucho");
                mushi_coin = 35;
            }
            else if (musi >= 8) //SR
            {
                sprite = Resources.Load<Sprite>("kuwagata");
                mushi_coin = 60;
            }
            image = kabutomusiImage.GetComponent<Image>();
            image.sprite = sprite;

            kirakiraImage.SetActive(false);
            kabutomusiImage.SetActive(true);

            toFieldButton.SetActive(false);
            Debug.Log("1•ªŒo‰ß");

        }
        else if (ts3.TotalMinutes <= 1)
        {
            //Text.text = "";
        }
    }

    public void OnkirikabuClick()
    {
        
        //–I–¨“h‚é
        if (!honey && GManager.instance.honey == true)
        {

            //SceneManager.LoadScene("Field");
            dt = DateTime.Now; //“h‚Á‚½ŽžŠÔ
            Debug.Log(dt);

            honey = true;
            GManager.instance.paint_honey = true;
            GManager.instance.honey = false;
            kirakiraImage.SetActive(true);

        } else if(GManager.instance.honey == false)
        {
            honeyPanel.SetActive(true);
            StartCoroutine("wait");
        }

    }


    public void catch_mushi()
    {
        Debug.Log("clicked");
        honey = false;
        GManager.instance.paint_honey = false;
        kabutomusiImage.SetActive(false);
        GManager.instance.coin += mushi_coin;
        toFieldButton.SetActive(true);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        honeyPanel.SetActive(false);
        yield break;
    }
}
