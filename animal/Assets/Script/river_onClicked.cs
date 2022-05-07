using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class river_onClicked : MonoBehaviour
{
    public static Vector2 cat_nearRiver;
    public static Vector2 cat_initialPosition;
    public static bool FromRiverToField;
    [SerializeField] GameObject cat_river;
    [SerializeField] GameObject cat_initial;
    // Start is called before the first frame update
    void Start()
    {
        cat_river.SetActive(false);
        cat_initial.SetActive(true);
        //Vector3 initialPosition = GameObject.Find("cat").transform.position;
        //cat_initialPosition = initialPosition;

        //if (FromRiverToField == true)
        //{
            //Vector3 tmp = GameObject.Find("cat").transform.position;
            //GameObject.Find("cat").transform.position = new Vector2(cat_nearRiver.x, cat_nearRiver.y);
            //FromRiverToField = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked()
    {
        //Debug.Log("clicked");
        StartCoroutine("load_River");
    }

    IEnumerator load_River()
    {
        //Vector3 tmp = GameObject.Find("cat").transform.position;
        //tmp = cat_initialPosition;
        //Debug.Log("position:" + tmp.x + "," + tmp.y);
        //GameObject.Find("cat").transform.position = new Vector2(tmp.x-5, tmp.y+4);
        //Vector3 tmp2 = GameObject.Find("cat").transform.position;
        //Debug.Log("position:" + tmp2.x + "," + tmp2.y);
        //cat_nearRiver = tmp2;
        cat_initial.SetActive(false);
        cat_river.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("fishScene");
    }
}