using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateData : MonoBehaviour
{
  
    public Sprite _image;
    public GameObject gO;
    
    GameObject localObject;
    List<GameObject> totalObjects=new List<GameObject>();
    private void Start()=> GenData();
    


    void Data(int i, int j)
    {
        Vector2 pos = new Vector2(i, j);
        GameObject localgObject = Instantiate(gO);
        localgObject.transform.localPosition = pos;

     
       
    }
    void GenData()
    {
        localObject = Instantiate(gO);
        localObject.transform.SetParent(this.transform);
        localObject.GetComponent<Image>().sprite = _image;
        localObject.SetActive(true);
        localObject.transform.localPosition=new Vector3(0,0,0);

        int swapper = 0;
        for (int i = 0; i < localObject.GetComponent<Image>().sprite.texture.width;++i)
        {
            for (int j = 0; j < localObject.GetComponent<Image>().sprite.texture.height;++j)
            {

               
                if (swapper % 2 == 0)
                {
                    Color local = new Color();
                    local.a = 0;
                    localObject.GetComponent<Image>().sprite.texture.SetPixel(i, j, local);

                }
                else
                {
                    localObject.GetComponent<Image>().sprite.texture.SetPixel(i, j, Color.white);
                }
                ++swapper;
            }
            
        }
      
    }

    //void GenData()
    //{


    //    for (int i = 50; i < _texture.width;)
    //    {
    //        for (int j = 50; j < _texture.height;)
    //        {
    //            Data(i, j);
    //            j += 100;
    //        }
    //        i += 100;
    //    }
    //    Debug.LogError(totalObjects.Count);
    //    foreach (GameObject child in totalObjects)
    //    {
    //        child.SetActive(true);
    //        child.transform.SetParent(this.transform);
    //    }
    //}

    //void Data(int i,int j)
    //{
    //    Vector2 pos = new Vector2(i,j);
    //    GameObject localgObject = Instantiate(gO);
    //    localgObject.transform.localPosition= pos;

    //    localgObject.GetComponent<Image>().color = _texture.GetPixel(i, j);
    //    totalObjects.Add(localgObject);
    //}
}
