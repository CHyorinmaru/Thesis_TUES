using UnityEngine;

public class ObjectDetector : MonoBehaviour
{

    [SerializeField]
    private int raycastLength = 5;

    [SerializeField]
    private Transform raycastSource;
    [SerializeField]
    private InfoController infoController;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(raycastSource.position, raycastSource.TransformDirection(Vector3.forward), out hit, raycastLength))
        {
            if(hit.transform.tag.Equals("Object"))
            {
                var text = hit.transform.GetComponent<ObjectInfo>().info.text;
                infoController.LoadTextInPlaceholder(text);
            }
        }
        else
        {
            infoController.ClearPlaceholder();
        }
    }
}
