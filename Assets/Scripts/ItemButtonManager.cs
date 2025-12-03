using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ItemButtonManager : MonoBehaviour
{
    private string itemName;
    private string itemDescription;
    private Sprite itemImage;
    private GameObject item3DModel;
    private ARInteractionManager interactionManager;
    private string urlBundleModel;
    private RawImage imageBundle;
    public string ItemName
    {
        set
        {
            itemName = value;
        }
    }
    public string ItemDescription { set => itemDescription = value; }
    public Sprite ItemImage { set => itemImage = value; }
    public GameObject Item3DModel {  set => item3DModel = value; }
    public string URLBundleModel { set => urlBundleModel = value; }
    public RawImage ImageBundle { get => imageBundle; set => imageBundle = value; }

    void Start()
    {
        transform.GetChild(0).GetComponent<Text>().text = itemName;
        //transform.GetChild(1).GetComponent<RawImage>().texture = itemImage.texture;
        imageBundle = transform.GetChild(1).GetComponent<RawImage>();
        transform.GetChild(2).GetComponent<Text>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.Instance.ARPosition);
        button.onClick.AddListener(Create3DModel);

        interactionManager = FindFirstObjectByType<ARInteractionManager>();
    }

    private void Create3DModel()
    {
        //interactionManager.Item3DModel = Instantiate(item3DModel);
        StartCoroutine(DownloadAssetBundle(urlBundleModel));
    }

    IEnumerator DownloadAssetBundle (string urlAssetBundle)
    {
        UnityWebRequest serverRequest = UnityWebRequestAssetBundle.GetAssetBundle(urlAssetBundle);
        yield return serverRequest.SendWebRequest();
        if (serverRequest.result == UnityWebRequest.Result.Success)
        {
            AssetBundle model3D = DownloadHandlerAssetBundle.GetContent(serverRequest);
            if (model3D != null) 
            { 
                interactionManager.Item3DModel = Instantiate(model3D.LoadAsset(model3D.GetAllAssetNames()[0]) as GameObject);
            }
            else
            {
                Debug.Log("Asset invalido");
            }

        }else
        {
            Debug.Log("Error");
        }
    }
}
