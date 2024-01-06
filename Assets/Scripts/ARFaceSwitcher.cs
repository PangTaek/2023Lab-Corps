using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ARFaceSwitcher : MonoBehaviour
{
    private ARFaceManager arFaceManager;
    private Material currentMaterial;

    private void Awak()
    {
        arFaceManager = GetComponent<ARFaceManager>();
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;
    }

    public void UpdateFaceMaterial(Material material)
    {
        Debug.Log(material.ToString());
        currentMaterial = material;
    }

    void Update()
    {
        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = currentMaterial;
        }
    }
}
