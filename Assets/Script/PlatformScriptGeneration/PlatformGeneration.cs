using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
[SerializeField] GameObject platformPrefab;
[SerializeField]GameObject firstPlatform;

[SerializeField] float distanceY =10f;

Vector3 lastInstancePlatform;

 Camera cameraMain;
    void Awake()
    {
        cameraMain =Camera.main;
    }
    void Start()
    {
        lastInstancePlatform = firstPlatform.transform.position;
    }

    void Update()
    {
        if (cameraMain.transform.position.y > lastInstancePlatform.y - 8)
        {
            float randomX = Random.Range(-10f,10f);
            while(Mathf.Abs(randomX - lastInstancePlatform.x) < 5f )
            {
               randomX = Random.Range(-10f,10f);
            }
          
            Vector3 newPlatformPos = new Vector3(randomX,lastInstancePlatform.y + distanceY,0);
            Instantiate(platformPrefab,newPlatformPos,Quaternion.identity);
            lastInstancePlatform = newPlatformPos;
        }
    }
}
