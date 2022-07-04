using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class river_toField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClicked()
    {
        //Debug.Log("clicked");
        river_onClicked.FromRiverToField = true;
        //StartCoroutine("load_Field");
        SceneManager.LoadScene("Field");
    }

    //IEnumerator load_Field()
    //{
        //Vector3 tmp = GameObject.Find("cat").transform.position;
        //Debug.Log("position:" + tmp.x + "," + tmp.y);
        //GameObject.Find("cat").transform.position = new Vector2(tmp.x - 7, tmp.y + 4);
        //Vector3 tmp2 = GameObject.Find("cat").transform.position;
        //Debug.Log("position:" + tmp2.x + "," + tmp2.y);
        //yield return new WaitForSeconds(3);
        //SceneManager.LoadScene("Field");
    //}
}
