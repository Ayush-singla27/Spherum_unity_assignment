using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateDistance : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;

    public GameObject spheres;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 disVec = cube1.position - cube2.position;
        float dis = disVec.magnitude-1;
        this.GetComponent<TextMeshProUGUI>().text = dis.ToString();

        if (dis < 2f) spheres.SetActive(true);
        else if (dis > 2f) spheres.SetActive(false);
        if (dis < 1f) SceneManager.LoadScene("scene2");
    }
}
