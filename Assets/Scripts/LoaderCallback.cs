using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    private bool firstUpdata = true;

    private void Update() {
        if (firstUpdata) {
            firstUpdata = false;
            Loader.LoaderCallback();
        }
    }
}
