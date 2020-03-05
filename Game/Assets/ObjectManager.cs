using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ObjectManager : MonoBehaviour
{

    private Object[] objects;

    public GameObject objectPrefab;

    void Start()
    {
        StartCoroutine(GetObjectsFromServer());
    }

    IEnumerator GetObjectsFromServer()
    {
        var url = "localhost:3000/objs/";

        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
                StartCoroutine(GetObjectsFromServer());
            }
            else
            {
                objects = JsonHelper.FromJson<Object>(webRequest.downloadHandler.text);
                LoadInfo();
            }
        }
    }

    void LoadInfo()
    {
        foreach(Object info in objects)
        {
            var obj = Instantiate(objectPrefab);
            obj.GetComponent<ObjectInfo>().SetInfo(info);
        }
    }
}