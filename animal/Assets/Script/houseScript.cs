using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class houseScript : MonoBehaviour
{
    public static Vector2 cat_nearTree;
    public static Vector2 cat_initialPosition;
    public static bool FromTreeToField;
    [SerializeField] GameObject cat_house;
    [SerializeField] GameObject cat_initial;

    public Image image;
    private Sprite sprite;
    [SerializeField] GameObject houseButton;
    // Start is called before the first frame update
    void Start()
    {
        cat_house.SetActive(false);
        cat_initial.SetActive(true);
        //Vector3 initialPosition = GameObject.Find("cat").transform.position;
        //cat_initialPosition = initialPosition;

        if(GManager.instance.houselevel == 1)
        {
            sprite = Resources.Load<Sprite>("house2");
            image = houseButton.GetComponent<Image>();
            image.sprite = sprite;
        } else if(GManager.instance.houselevel == 2) 
        {
            sprite = Resources.Load<Sprite>("house3");
            image = houseButton.GetComponent<Image>();
            image.sprite = sprite;
        } else
        {
            sprite = Resources.Load<Sprite>("house1");
            image = houseButton.GetComponent<Image>();
            image.sprite = sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked()
    {
        //Debug.Log("clicked");
        StartCoroutine("load_House");
    }

    IEnumerator load_House()
    {
        //Vector3 tmp = GameObject.Find("cat").transform.position;
        //tmp = cat_initialPosition;
        //Debug.Log("position:" + tmp.x + "," + tmp.y);
        //GameObject.Find("cat").transform.position = new Vector2(tmp.x + 4, tmp.y + 1);
        //Vector3 tmp3 = GameObject.Find("cat").transform.position;
        //Debug.Log("position:" + tmp3.x + "," + tmp3.y);
        //cat_nearTree = tmp3;
        cat_initial.SetActive(false);
        cat_house.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("buyScene");
    }
}
