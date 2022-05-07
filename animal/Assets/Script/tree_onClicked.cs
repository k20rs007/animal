using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tree_onClicked : MonoBehaviour
{
    public static Vector2 cat_nearTree;
    public static Vector2 cat_initialPosition;
    public static bool FromTreeToField;

    [SerializeField] GameObject cat_tree;
    [SerializeField] GameObject cat_initial;

    // Start is called before the first frame update
    void Start()
    {
        cat_tree.SetActive(false);
        cat_initial.SetActive(true);
        //Vector3 initialPosition = GameObject.Find("cat").transform.position;
        //cat_initialPosition = initialPosition;

        //if (FromTreeToField == true)
        //{
            //Vector3 tmp = GameObject.Find("cat").transform.position;
            //GameObject.Find("cat").transform.position = new Vector2(cat_nearTree.x, cat_nearTree.y);
            //FromTreeToField = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClicked()
    {
        //Debug.Log("clicked");
        StartCoroutine("load_Tree");
    }

    IEnumerator load_Tree()
    {
        //Vector3 tmp = GameObject.Find("cat").transform.position;
        //tmp = cat_initialPosition;
        //Debug.Log("position:" + tmp.x + "," + tmp.y);
        //GameObject.Find("cat").transform.position = new Vector2(tmp.x+4, tmp.y+1);
        //Vector3 tmp3 = GameObject.Find("cat").transform.position;
        //Debug.Log("position:" + tmp3.x + "," + tmp3.y);
        //cat_nearTree = tmp3;
        cat_initial.SetActive(false);
        cat_tree.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("catchScene");
    }
}